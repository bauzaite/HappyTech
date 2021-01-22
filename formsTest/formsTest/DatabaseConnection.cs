using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace formsTest
{
    class DatabaseConnection
    {
        private string connectionString;
        private static DatabaseConnection instanceOfDatabaseConnection;
        public DatabaseConnection()
        {
            connectionString = Properties.Settings.Default.formsTest;
        }
        // Open the connection
        public static DatabaseConnection getDatabaseConnection()
        {
            if (instanceOfDatabaseConnection == null)
            {
                instanceOfDatabaseConnection = new DatabaseConnection();
            }
            return instanceOfDatabaseConnection;
        }
        public DataSet getData()
        {
            string sqlQuery = "SELECT * FROM TestTable";

            DataSet dataSet = new DataSet();

            SqlConnection sqlCon;
            using (sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, sqlCon);
                dataAdapter.Fill(dataSet);

            }
            return dataSet;
        }
    }
}