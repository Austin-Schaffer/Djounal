using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Djounal
{
    public partial class MainMenu : Form
    {
        private MySqlConnection m_conn;
        //public event FormClosingEventHandler MainMenu_FormClosing;

        public MainMenu()
        {
            InitializeComponent();
            SetServiceStatus();

            //  Initialize Connection
            string strConnection = "Server=localhost; Database=djournal; Uid=root; Pwd=vespas;";
            MySqlConnection conn = new MySqlConnection(strConnection);
            conn.Open();
            m_conn = conn;

            //  Add Event Handler
            this.FormClosing += new FormClosingEventHandler(MainMenu_FormClosing);
        }

        private void SetServiceStatus()
        {
            if(ServiceIsRunning())
            {
                this.txtServiceStatus.Text = "Running";
                this.btnStartStopService.Text = "Stop";
            } else
            {
                this.txtServiceStatus.Text = "Stopped";
                this.btnStartStopService.Text = "Start";
            }
        }

        private bool ServiceIsRunning()
        {
            //  TODO: Check if service is running
            return true;
        }

        private void btnStartQuestionnaire_Click(object sender, EventArgs e)
        {
            Questionnaire newForm = new Questionnaire(m_conn);
            newForm.ShowDialog();
        }

        private void btnPreviousEntries_Click(object sender, EventArgs e)
        {
            QuestionnaireList newForm = new QuestionnaireList(m_conn);
            newForm.ShowDialog();
        }

        private void MainMenu_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Djournal", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }

            //  Close the connection
            m_conn.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings newForm = new Settings(m_conn);
            newForm.ShowDialog();
        }
    }
}
