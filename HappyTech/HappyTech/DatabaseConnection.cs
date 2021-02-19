using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace HappyTech
{
    static class DatabaseConnection
    {
        private static string connectionString = Properties.Settings.Default.dbConnection;

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
        public static void createTemplate(string sqlQuery, string templateTitle, string templateText, string templateCategory, int templateSuccessful)
        {
            SqlConnection sqlCon;
            using (sqlCon = new SqlConnection(connectionString))
            {

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@templateTitle", templateTitle);
                sqlCommand.Parameters.AddWithValue("@templateText", templateText);
                sqlCommand.Parameters.AddWithValue("@templateCategory", templateCategory);
                sqlCommand.Parameters.AddWithValue("@templateSuccessful", templateSuccessful);

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
