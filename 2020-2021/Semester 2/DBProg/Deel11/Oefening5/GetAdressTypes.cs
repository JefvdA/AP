using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void GetAdressTypes ()
    {
        using(SqlConnection conn = new SqlConnection("context connection=true"))
        {
            string query = @"
                        SELECT
                            [AdressTypeID],
                            [Name]
                        FROM
                            [Person].[AdressType]
                        ORDER BY
                            [AdressTypeID]";
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            SqlContext.Pipe.Send(reader);
            SqlContext.Pipe.Send(System.DateTime.Today.ToString());
            reader.Close();
        }
    }
}
