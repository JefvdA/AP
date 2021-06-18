using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void PriceSum (out SqlDecimal totalValue)
    {
        using(SqlConnection conn = new SqlConnection("context connection=true"))
        {
            string query = @"
                            SELECT
                                SUM([ListPrice])
                            FROM
                                [Production].[Product]";

            totalValue = 0;
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            totalValue = new SqlDecimal(Convert.ToDecimal(sqlCommand.ExecuteScalar()));
        }
    }
}
