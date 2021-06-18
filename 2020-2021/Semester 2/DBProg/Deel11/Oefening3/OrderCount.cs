using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction(DataAccess =DataAccessKind.Read)]
    public static SqlInt32 OrderCount()
    {
        string query = @"
                        Select
                            COUNT(*) AS [Order count]
                        FROM
                            [Sales].[SalesOrderHeader]";

        using(SqlConnection conn = new SqlConnection("context connection=true"))
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            return new SqlInt32(Convert.ToInt32(sqlCommand.ExecuteScalar()));
        }
    }
}
