using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int counter = 0;

            string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

            string commandText = "SELECT top 100 * FROM Person.Person";
            SqlCommand sqlCommand = new SqlCommand(commandText);

            SqlDataReader reader;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                sqlCommand.Connection = conn;
                conn.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    counter++;
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();

                    tbOutput.AppendText($"{counter}     {firstName} {lastName} \n");
                }
            }
        }
    }
}
