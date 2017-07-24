namespace Djounal
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnStartStopService = new System.Windows.Forms.Button();
            this.btnStartQuestionnaire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceStatus = new System.Windows.Forms.TextBox();
            this.btnPreviousEntries = new System.Windows.Forms.Button();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartStopService
            // 
            this.btnStartStopService.Location = new System.Drawing.Point(203, 42);
            this.btnStartStopService.Name = "btnStartStopService";
            this.btnStartStopService.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopService.TabIndex = 0;
            this.btnStartStopService.Text = "Start";
            this.btnStartStopService.UseVisualStyleBackColor = true;
            // 
            // btnStartQuestionnaire
            // 
            this.btnStartQuestionnaire.Location = new System.Drawing.Point(97, 71);
            this.btnStartQuestionnaire.Name = "btnStartQuestionnaire";
            this.btnStartQuestionnaire.Size = new System.Drawing.Size(181, 23);
            this.btnStartQuestionnaire.TabIndex = 1;
            this.btnStartQuestionnaire.Text = "Start Questionnaire";
            this.btnStartQuestionnaire.UseVisualStyleBackColor = true;
            this.btnStartQuestionnaire.Click += new System.EventHandler(this.btnStartQuestionnaire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service Status:";
            // 
            // txtServiceStatus
            // 
            this.txtServiceStatus.Location = new System.Drawing.Point(97, 42);
            this.txtServiceStatus.Name = "txtServiceStatus";
            this.txtServiceStatus.ReadOnly = true;
            this.txtServiceStatus.Size = new System.Drawing.Size(100, 20);
            this.txtServiceStatus.TabIndex = 3;
            // 
            // btnPreviousEntries
            // 
            this.btnPreviousEntries.Location = new System.Drawing.Point(97, 100);
            this.btnPreviousEntries.Name = "btnPreviousEntries";
            this.btnPreviousEntries.Size = new System.Drawing.Size(181, 23);
            this.btnPreviousEntries.TabIndex = 4;
            this.btnPreviousEntries.Text = "Previous Quentionnaires";
            this.btnPreviousEntries.UseVisualStyleBackColor = true;
            this.btnPreviousEntries.Click += new System.EventHandler(this.btnPreviousEntries_Click);
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(97, 130);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(181, 23);
            this.btnViewData.TabIndex = 5;
            this.btnViewData.Text = "View Data";
            this.btnViewData.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(97, 159);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(181, 23);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 283);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.btnPreviousEntries);
            this.Controls.Add(this.txtServiceStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartQuestionnaire);
            this.Controls.Add(this.btnStartStopService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Djournal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStopService;
        private System.Windows.Forms.Button btnStartQuestionnaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceStatus;
        private System.Windows.Forms.Button btnPreviousEntries;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnSettings;
    }
}

