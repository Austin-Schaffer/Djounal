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
    public partial class QuestionnaireList : Form
    {
        private MySqlConnection m_conn;

        public QuestionnaireList(MySqlConnection conn)
        {
            InitializeComponent();

            m_conn = conn;
            PopulateList();
        }

        private void PopulateList()
        {
            MySqlCommand command = m_conn.CreateCommand();
            MySqlDataReader reader;
            command.CommandText = "SELECT * FROM entries;";

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                DateTime dateEntry = reader.GetDateTime("entryTimeStamp");
                this.lvQuestionnaires.Items.Add(dateEntry.ToString());
            }
            reader.Close();
        }
    }
}
