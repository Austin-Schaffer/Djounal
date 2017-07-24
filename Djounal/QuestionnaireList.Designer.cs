namespace Djounal
{
    partial class QuestionnaireList
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
            this.lvQuestionnaires = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Completed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvQuestionnaires
            // 
            this.lvQuestionnaires.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Completed});
            this.lvQuestionnaires.Location = new System.Drawing.Point(12, 12);
            this.lvQuestionnaires.Name = "lvQuestionnaires";
            this.lvQuestionnaires.Size = new System.Drawing.Size(260, 237);
            this.lvQuestionnaires.TabIndex = 0;
            this.lvQuestionnaires.UseCompatibleStateImageBehavior = false;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Completed
            // 
            this.Completed.Text = "Completed";
            // 
            // QuestionnaireList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lvQuestionnaires);
            this.Name = "QuestionnaireList";
            this.Text = "QuestionnaireList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvQuestionnaires;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Completed;
    }
}