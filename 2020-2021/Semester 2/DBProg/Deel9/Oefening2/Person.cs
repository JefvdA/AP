using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace Oefening2
{
    class Person
    {
        public static int GetCount()
        {
            int retValue = -1;

            string commandText = "SELECT Count(*) FROM Person.Person";
            SqlCommand sqlCommand = new SqlCommand(commandText);

            using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString))
            {
                sqlCommand.Connection = conn;
                conn.Open();
                retValue = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }

            return retValue;
        }
    }
}
