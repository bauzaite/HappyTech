using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace formsTest
{
    static class DatabaseConnection
    {
        private static string connectionString = Properties.Settings.Default.formsTest;

        public static DataSet getData(string sqlQuery)
        { 
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
        public static void saveToDb(string sqlQuery, string templateTitle, string templateText)
        {
            SqlConnection sqlCon;
            using (sqlCon = new SqlConnection(connectionString))
            {
                
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@templateTitle", templateTitle);
                sqlCommand.Parameters.AddWithValue("@templateText", templateText);

                sqlCon.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
        public static bool getCredentials(string sqlQuery, string username, string password)
        {
            bool passwordCheck;
            SqlConnection sqlCon;
            using (sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    passwordCheck = true;
                    reader.Close();
                }
                else 
                {
                    passwordCheck = false;
                    reader.Close();
                }
            }
            return passwordCheck;
        }
    }
}