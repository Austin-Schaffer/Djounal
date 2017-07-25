namespace Djounal
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddField = new System.Windows.Forms.Button();
            this.btnRemoveField = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProfiles = new System.Windows.Forms.ComboBox();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkShowAd = new System.Windows.Forms.CheckBox();
            this.linkAdExplanation = new System.Windows.Forms.LinkLabel();
            this.tvFields = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxFieldDataType = new System.Windows.Forms.ComboBox();
            this.chkFieldEnabled = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSubField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profile:";
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(92, 235);
            this.btnAddField.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(100, 28);
            this.btnAddField.TabIndex = 4;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // btnRemoveField
            // 
            this.btnRemoveField.Location = new System.Drawing.Point(326, 235);
            this.btnRemoveField.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveField.Name = "btnRemoveField";
            this.btnRemoveField.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveField.TabIndex = 5;
            this.btnRemoveField.Text = "Remove";
            this.btnRemoveField.UseVisualStyleBackColor = true;
            this.btnRemoveField.Click += new System.EventHandler(this.btnRemoveField_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "My Fields:";
            // 
            // cbxProfiles
            // 
            this.cbxProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfiles.FormattingEnabled = true;
            this.cbxProfiles.Location = new System.Drawing.Point(92, 7);
            this.cbxProfiles.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProfiles.Name = "cbxProfiles";
            this.cbxProfiles.Size = new System.Drawing.Size(160, 24);
            this.cbxProfiles.TabIndex = 7;
            this.cbxProfiles.SelectedIndexChanged += new System.EventHandler(this.cbxProfiles_SelectedIndexChanged);
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.Location = new System.Drawing.Point(261, 7);
            this.btnNewProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(100, 28);
            this.btnNewProfile.TabIndex = 8;
            this.btnNewProfile.Text = "New";
            this.btnNewProfile.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(581, 444);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(473, 444);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 28);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Save";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 446);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Show Advertisement:";
            // 
            // chkShowAd
            // 
            this.chkShowAd.AutoSize = true;
            this.chkShowAd.Checked = true;
            this.chkShowAd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowAd.Location = new System.Drawing.Point(167, 446);
            this.chkShowAd.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowAd.Name = "chkShowAd";
            this.chkShowAd.Size = new System.Drawing.Size(18, 17);
            this.chkShowAd.TabIndex = 12;
            this.chkShowAd.UseVisualStyleBackColor = true;
            // 
            // linkAdExplanation
            // 
            this.linkAdExplanation.AutoSize = true;
            this.linkAdExplanation.Location = new System.Drawing.Point(195, 446);
            this.linkAdExplanation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAdExplanation.Name = "linkAdExplanation";
            this.linkAdExplanation.Size = new System.Drawing.Size(78, 17);
            this.linkAdExplanation.TabIndex = 13;
            this.linkAdExplanation.TabStop = true;
            this.linkAdExplanation.Text = "Read More";
            this.linkAdExplanation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdExplanation_LinkClicked);
            // 
            // tvFields
            // 
            this.tvFields.Location = new System.Drawing.Point(92, 43);
            this.tvFields.Margin = new System.Windows.Forms.Padding(4);
            this.tvFields.Name = "tvFields";
            this.tvFields.Size = new System.Drawing.Size(335, 184);
            this.tvFields.TabIndex = 14;
            this.tvFields.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvFields_NodeMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name:";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(521, 43);
            this.txtFieldName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(160, 22);
            this.txtFieldName.TabIndex = 16;
            this.txtFieldName.TextChanged += new System.EventHandler(this.txtFieldName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Location = new System.Drawing.Point(444, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Active:";
            // 
            // cbxFieldDataType
            // 
            this.cbxFieldDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFieldDataType.FormattingEnabled = true;
            this.cbxFieldDataType.Location = new System.Drawing.Point(521, 73);
            this.cbxFieldDataType.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFieldDataType.Name = "cbxFieldDataType";
            this.cbxFieldDataType.Size = new System.Drawing.Size(160, 24);
            this.cbxFieldDataType.TabIndex = 20;
            this.cbxFieldDataType.SelectedIndexChanged += new System.EventHandler(this.cbxFieldDataType_SelectedIndexChanged);
            // 
            // chkFieldEnabled
            // 
            this.chkFieldEnabled.AutoSize = true;
            this.chkFieldEnabled.Checked = true;
            this.chkFieldEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFieldEnabled.Location = new System.Drawing.Point(521, 105);
            this.chkFieldEnabled.Margin = new System.Windows.Forms.Padding(4);
            this.chkFieldEnabled.Name = "chkFieldEnabled";
            this.chkFieldEnabled.Size = new System.Drawing.Size(18, 17);
            this.chkFieldEnabled.TabIndex = 21;
            this.chkFieldEnabled.UseVisualStyleBackColor = true;
            this.chkFieldEnabled.CheckedChanged += new System.EventHandler(this.chkFieldActive_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 302);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 123);
            this.panel1.TabIndex = 22;
            // 
            // btnAddSubField
            // 
            this.btnAddSubField.Location = new System.Drawing.Point(200, 235);
            this.btnAddSubField.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSubField.Name = "btnAddSubField";
            this.btnAddSubField.Size = new System.Drawing.Size(118, 28);
            this.btnAddSubField.TabIndex = 24;
            this.btnAddSubField.Text = "Add Sub-Field";
            this.btnAddSubField.UseVisualStyleBackColor = true;
            this.btnAddSubField.Click += new System.EventHandler(this.btnAddSubField_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 485);
            this.Controls.Add(this.btnAddSubField);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkFieldEnabled);
            this.Controls.Add(this.cbxFieldDataType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tvFields);
            this.Controls.Add(this.linkAdExplanation);
            this.Controls.Add(this.chkShowAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewProfile);
            this.Controls.Add(this.cbxProfiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveField);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Button btnRemoveField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProfiles;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkShowAd;
        private System.Windows.Forms.LinkLabel linkAdExplanation;
        private System.Windows.Forms.TreeView tvFields;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxFieldDataType;
        private System.Windows.Forms.CheckBox chkFieldEnabled;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSubField;
    }
}