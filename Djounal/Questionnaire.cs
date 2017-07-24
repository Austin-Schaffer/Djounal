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
    public partial class Questionnaire : Form
    {
        private MySqlConnection m_conn;

        public Questionnaire(MySqlConnection conn)
        {
            InitializeComponent();

            m_conn = conn;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlCommand command = m_conn.CreateCommand();
            command.CommandText = "INSERT INTO entries (entryHoursSlept) VALUES (" + this.nudHoursSlept.Value + ");";
            command.ExecuteNonQuery();
            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
