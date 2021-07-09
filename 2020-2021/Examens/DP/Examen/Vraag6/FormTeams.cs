using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Vraag6
{
    public partial class FormTeams : Form
    {
        public FormTeams()
        {
            InitializeComponent();
            InitializeComboBoxPlayer();
        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                if(string.IsNullOrEmpty(textBoxTeamNumber.Text) || string.IsNullOrEmpty(textBoxDivision.Text))
                {
                    MessageBox.Show("U heeft niet alles ingevuld");
                }
                else if (doesTeamExist())
                {
                    MessageBox.Show("Dit team bestaat al, probeer opnieuw!");
                }
                else
                {
                    conn.Open();
                    string commandText = "INSERT INTO [dbo].[TEAMS](TEAMNR, SPELERSNR, DIVISIE) VALUES(@param1,@param2,@param3)";
                    using (SqlCommand sqlCommand = new SqlCommand(commandText, conn))
                    {
                        sqlCommand.Parameters.Add("@param1", SqlDbType.Int).Value = Convert.ToInt32(textBoxTeamNumber.Text);
                        sqlCommand.Parameters.Add("@param2", SqlDbType.Int).Value = Convert.ToInt32("2"); // Hier zou spelersnr moeten komen uit comboBox
                        sqlCommand.Parameters.Add("@param3", SqlDbType.VarChar).Value = Convert.ToInt32(textBoxDivision.Text);
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        private void InitializeComboBoxPlayer()
        {
            SqlDataReader rdr;

            string commandText = "SELECT * FROM [dbo].[SPELERS]";

            SqlCommand sqlCommand = new SqlCommand(commandText);
            sqlCommand.CommandType = CommandType.Text;

            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                sqlCommand.Connection = conn;
                conn.Open();
                rdr = sqlCommand.ExecuteReader();

                while (rdr.Read())
                {
                    comboBoxPlayer.Items.Add($"{rdr["VOORLETTERS"]}.{rdr["NAAM"]}");
                }
            }
        }

        private bool doesTeamExist()
        {
            return false;
        }
    }
}
