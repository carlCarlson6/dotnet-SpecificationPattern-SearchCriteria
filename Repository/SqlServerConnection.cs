using System;
using System.Data.SqlClient;

namespace Repository
{
    public class SqlServerConnection
    {
        private static SqlConnection instance;

        private SqlServerConnection() { }

        public static SqlConnection GetConnection(String connectionString)
        {
            SqlConnection connection;
            
            if(instance == null)
            {
                instance = new SqlConnection(connectionString);
            }
            
            connection = instance;
            return connection;
        }
    }
}
