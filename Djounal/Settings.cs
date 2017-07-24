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

        // DB variables
        private string m_selectedProfile;
        private DateTime m_adDisableDate;
        
        public Settings(MySqlConnection conn)
        {
            InitializeComponent();
            this.m_conn = conn;

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
            
            // Load Profiles
            foreach (string strFilePath in Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.profile"))
            {
                string strProfileName = Path.GetFileNameWithoutExtension(strFilePath);
                this.cbxProfiles.Items.Add(strProfileName);
                if (strProfileName == m_selectedProfile)
                {
                    LoadTree(strFilePath);
                    this.cbxProfiles.SelectedValue = strProfileName;
                }
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

            XmlNodeList nodeChildren = xmlFile.ChildNodes;
        }

        private void SaveTree()
        {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateElement("RootNode"));
            
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
            }
            doc.Save(this.cbxProfiles.SelectedText + ".profile");
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
            cmd.CommandText += (this.chkShowAd.Checked) ? "NULL, " : "NOW(), '";
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

        private void btnAddField_Click(object sender, EventArgs e)
        {
            // Get new node data
            string nodeName = this.txtFieldName.Text;
            if(nodeName == string.Empty) // Validate
            {
                m_errTxtFieldName.SetError(txtFieldName, "Cannot Be Empty");
                return;
            } else
            {
                m_errTxtFieldName.Clear();
            }
            FieldNode.FieldDataType dataType = (FieldNode.FieldDataType) this.cbxFieldDataType.SelectedIndex;
            bool boolIsEnabled = this.chkFieldEnabled.Checked;

            // Add node
            FieldNode nodeToAdd = new FieldNode(-1, nodeName, dataType, boolIsEnabled);
            tvFields.Nodes.Add(nodeToAdd);
            tvFields.SelectedNode = nodeToAdd;

            // Reset form
            //this.txtFieldName.Text = string.Empty;
            //this.cbxFieldDataType.SelectedIndex = 0;
            //this.chkFieldEnabled.Checked = true;

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
            UpdateTreeView();
        }

        private void cbxFieldDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTreeView();
        }

        private void chkFieldActive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTreeView();
        }

        private void tvFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("In order to fund the developement of this project in a small way, a single advertisement "
                + "will be shown with daily questionnaires. This may be disabled for 30 days by unchecking the appropriate "
                + "box. If this advertisement and its enablement system is too disruptive to your experience then please "
                + "contact the developer at schaffera23@gmail.com", "Advertisement Notice");
        }

        private void UpdateTreeView()
        {
            // Update the text on the node
            if (this.tvFields.SelectedNode == null) return;

            FieldNode nodeCurrent = (FieldNode)this.tvFields.SelectedNode;

            nodeCurrent.strFieldName = this.txtFieldName.Text;
            nodeCurrent.dataType = (FieldNode.FieldDataType)this.cbxFieldDataType.SelectedIndex;
            nodeCurrent.boolIsEnabled = this.chkFieldEnabled.Checked;

            string strNodeName = nodeCurrent.strFieldName + " [" + nodeCurrent.dataType + "]";
            this.tvFields.SelectedNode.Text = strNodeName;

            this.tvFields.SelectedNode.ForeColor = chkFieldEnabled.Checked ? Color.Black : Color.LightGray;
        }

        private void cbxProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load tree
        }

        private void tvFields_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FieldNode nodeCurrent = (FieldNode)e.Node;

            // Update form
            this.txtFieldName.Text = nodeCurrent.strFieldName;
            this.cbxFieldDataType.SelectedIndex = (int) nodeCurrent.dataType;
            this.chkFieldEnabled.Checked  = nodeCurrent.boolIsEnabled;
        }

        private void tvFields_Click(object sender, EventArgs e)
        {
            this.tvFields.SelectedNode = null;
        }
    }
}
