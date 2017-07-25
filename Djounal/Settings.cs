using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using MySql.Data.MySqlClient;

namespace Djounal
{
    public partial class Settings : Form
    {
        private MySqlConnection m_conn;
        private ErrorProvider m_errTxtFieldName;
        private bool boolPauseUpdates;

        // DB variables
        private string m_selectedProfile;
        private DateTime m_adDisableDate;
        
        public Settings(MySqlConnection conn)
        {
            InitializeComponent();
            this.m_conn = conn;
            boolPauseUpdates = false;

            // Load data types
            this.cbxFieldDataType.Items.Add("True/False");
            this.cbxFieldDataType.Items.Add("Number");
            this.cbxFieldDataType.Items.Add("Text");
            this.cbxFieldDataType.SelectedIndex = 0;
            
            // Initialize error provider
            m_errTxtFieldName = new ErrorProvider();
            m_errTxtFieldName.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Load settings from DB
            MySqlCommand query = m_conn.CreateCommand();
            query.CommandText = "SELECT * FROM settings LIMIT 1";
            MySqlDataReader reader = query.ExecuteReader();
            while(reader.Read())
            {
                m_selectedProfile = (string)reader["profileFileName"];
                m_adDisableDate = reader.GetDateTime("adDisabledDate");
            }
            reader.Close();

            // Load Profiles
            int i = 0;
            foreach (string strFilePath in Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.profile"))
            {
                string strProfileName = Path.GetFileNameWithoutExtension(strFilePath);
                this.cbxProfiles.Items.Add(strProfileName);
                if (strProfileName == m_selectedProfile)
                {
                    LoadTree(strFilePath);
                    this.cbxProfiles.SelectedIndex = i;
                }
                i++;
            }

            
            
        }

        private void ImportXml()
        {

        }

        private void ExportXml()
        {
            
        }

        private void LoadTree(string strFilePath)
        {
            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(strFilePath);

            this.tvFields.Nodes.Clear();
            XmlNodeList nodeChildren = xmlFile.FirstChild.ChildNodes;
            foreach (XmlNode nodeCurrent in nodeChildren)
            {
                AddNode(new FieldNode(nodeCurrent));
            }
        }

        private void SaveTree()
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateElement("Profile"));
            
            foreach(TreeNode node in this.tvFields.Nodes)
            {
                FieldNode nodeToSave = (FieldNode)node;
                AppendNodeToXml(nodeToSave, ref doc);
            }

            string strProfileName = this.cbxProfiles.SelectedText;
            if(strProfileName == string.Empty)
            {
                TextInput formTextInput = new TextInput();
                formTextInput.ShowDialog(this);
                strProfileName = formTextInput.txtProfileName.Text;
            }
            doc.Save(strProfileName + ".profile");
        }

        private void AppendNodeToXml(FieldNode nodeCur, ref XmlDocument doc)
        {
            XmlElement xmlNewNode = nodeCur.ToXml(doc);
            doc.DocumentElement.AppendChild(xmlNewNode);
            
            foreach(FieldNode nodeChild in nodeCur.Nodes)
            {
                AppendNodeToXml(nodeChild, ref doc);
            }
        }

        private void SaveSettings()
        {
            string strProfileName = this.cbxProfiles.SelectedText;
            
            MySqlCommand cmd = m_conn.CreateCommand();
            cmd.CommandText = "INSERT INTO settings (settingId, adDisabledDate, profileName) VALUES (1, ";
            cmd.CommandText += (this.chkShowAd.Checked) ? "NULL, " : "NOW(),";
            cmd.CommandText += strProfileName;
            cmd.CommandText += "') ON DUPLICATE KEY UPDATE adDisabledDate = ";
            cmd.CommandText += (this.chkShowAd.Checked) ? "NULL, " : "NOW(), ";
            cmd.CommandText += "profileName = " + strProfileName + ";";

            int intResult = cmd.ExecuteNonQuery();

        }

        private void linkAdExplanation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("In order to fund the developement of this project in a small way, a single advertisement "
                + "will be shown with daily questionnaires. This may be disabled for 30 days by unchecking the appropriate "
                + "box. If this advertisement and its enablement system is too disruptive to your experience then please "
                + "contact the developer at schaffera23@gmail.com", "Advertisement Notice");
        }
        
        private void AddNode(FieldNode nodeToAdd, FieldNode nodeParent = null, bool boolAddChildNodes = false)
        {
            // Add to parent if it exists
            if(nodeParent == null)
            {
                tvFields.Nodes.Add(nodeToAdd);
            } else
            {
                nodeParent.Nodes.Add(nodeToAdd);
            }

            // Add child nodes
            if(boolAddChildNodes == true)
            {
                foreach(FieldNode nodeChild in nodeToAdd.Nodes)
                {
                    AddNode(nodeChild, nodeToAdd, true);
                }
            }
            
            tvFields.SelectedNode = nodeToAdd;

            UpdateNode(nodeToAdd);
            UpdateFieldsFromNode(nodeToAdd);
            UpdateTreeView();
        }

        private void btnRemoveField_Click(object sender, EventArgs e)
        {
            if(tvFields.SelectedNode != null)
            {
                tvFields.SelectedNode.Remove();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //TODO: Detect Changes and alter table
            SaveTree();
            SaveSettings();
        }

        private void txtFieldName_TextChanged(object sender, EventArgs e)
        {
            if (boolPauseUpdates == true) return;
            FieldNode nodeToUpdate = (FieldNode)tvFields.SelectedNode;
            if (nodeToUpdate == null) return;
            nodeToUpdate.strFieldName = this.txtFieldName.Text;
            UpdateNode(nodeToUpdate);
        }

        private void cbxFieldDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boolPauseUpdates == true) return;
            FieldNode nodeToUpdate = (FieldNode)tvFields.SelectedNode;
            if (nodeToUpdate == null) return;
            nodeToUpdate.dataType = (FieldNode.FieldDataType)this.cbxFieldDataType.SelectedIndex;
            UpdateNode(nodeToUpdate);
        }

        private void chkFieldActive_CheckedChanged(object sender, EventArgs e)
        {
            if (boolPauseUpdates == true) return;
            FieldNode nodeToUpdate = (FieldNode)tvFields.SelectedNode;
            if (nodeToUpdate == null) return;
            nodeToUpdate.boolIsEnabled = this.chkFieldEnabled.Checked;
            UpdateNode(nodeToUpdate);
        }

        private void UpdateTreeView()
        {
            // Get the selected node if it exists
            FieldNode nodeCurrent = (FieldNode)this.tvFields.SelectedNode;
            if (nodeCurrent == null) return;

            // Update fields with node data
            this.txtFieldName.Text = nodeCurrent.strFieldName;
            this.cbxFieldDataType.SelectedIndex = (int)nodeCurrent.dataType;
            this.chkFieldEnabled.Checked = nodeCurrent.boolIsEnabled;
        }

        private void UpdateNode(FieldNode nodeToUpdate)
        {
            if(nodeToUpdate == null) return;

            // Change text
            string strNodeName = this.txtFieldName.Text + " [" + cbxFieldDataType.Text + "]";
            this.tvFields.SelectedNode.Text = strNodeName;

            // Update color
            this.tvFields.SelectedNode.ForeColor = chkFieldEnabled.Checked ? Color.Black : Color.LightGray;
        }

        private void UpdateFieldsFromNode(FieldNode node)
        {
            boolPauseUpdates = true;
            this.txtFieldName.Text = node.strFieldName;
            this.cbxFieldDataType.SelectedIndex = (int)node.dataType;
            this.chkFieldEnabled.Checked = node.boolIsEnabled;
            boolPauseUpdates = false;
        }

        private void cbxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get file path
            string strFilePath = Directory.GetCurrentDirectory() + "\\" + this.cbxProfiles.Text + ".profile";
            LoadTree(strFilePath);
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            FieldNode nodeNew = new FieldNode(0, "New Field", FieldNode.FieldDataType.Boolean, true);
            AddNode(nodeNew);
        }

        private void btnAddSubField_Click(object sender, EventArgs e)
        {
            FieldNode nodeNew = new FieldNode(0, "New Field", FieldNode.FieldDataType.Boolean, true);
            AddNode(nodeNew, (FieldNode)tvFields.SelectedNode);
        }

        private void tvFields_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FieldNode nodeSelected = (FieldNode)e.Node;
            this.tvFields.SelectedNode = nodeSelected;
            UpdateFieldsFromNode(nodeSelected);
        }
    }
}
