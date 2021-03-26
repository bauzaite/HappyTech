using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HappyTech
{
    /// <summary>
    ///  WIP
    ///  This class created a connection ith the database
    ///  seems ike we create 3 connections here.
    ///  // TODO: Make sure only 1 connection is created?
    /// </summary>
    static class DatabaseConnection
    {
        private static string connectionString = Properties.Settings.Default.dbConnection;

        /// <summary>
        /// This isnt used anywhere
        /// WIP!
        /// </summary>
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
        public static void createTemplate(string sqlQuery, string templateTitle, string templateText1, string templateText2, string templateText3, string templateText4, string templateText5, string templateCategory, int templateSuccessful)
        {
            SqlConnection sqlCon;
            using (sqlCon = new SqlConnection(connectionString))
            {

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@templateTitle", templateTitle);
                sqlCommand.Parameters.AddWithValue("@templateText_1", templateText1);
                sqlCommand.Parameters.AddWithValue("@templateText_2", templateText2);
                sqlCommand.Parameters.AddWithValue("@templateText_3", templateText3);
                sqlCommand.Parameters.AddWithValue("@templateText_4", templateText4);
                sqlCommand.Parameters.AddWithValue("@templateText_5", templateText5);
                sqlCommand.Parameters.AddWithValue("@templateCategory", templateCategory);
                sqlCommand.Parameters.AddWithValue("@templateSuccessful", templateSuccessful);

                sqlCon.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        public static string insertData(string sqlQuery, bool query)
        {
            int id = 0;
            SqlConnection sc;
            using (sc = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand();
                //sc.ConnectionString = (connectionString);
                sc.Open();

                com.Connection = sc;
                com.CommandText = (sqlQuery);

                if (query == true)
                {
                    id = (int)com.ExecuteScalar();
                }
                else
                {
                    com.ExecuteNonQuery();
                }
                sc.Close();
            }
            return id.ToString();
        }

        public static bool getCredentials(string sqlQuery)
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

        /// <summary>
        /// This is used to send a SQL Command to the Database
        /// and the output of command gets returned in a string.
        /// </summary>
        /// <param name="sqlQuery">SQL Command sent to  the Database</param>
        /// <param name="number">If you are expecting a number to be returned</param>
        /// <returns>String of the SQL Command return</returns>
        public static string basicRequest(string sqlQuery, bool number)
        {
            string SQLReturn = "Error!";
            SqlConnection sqlConn;
            using (sqlConn = new SqlConnection(connectionString))
            {
                //open connection
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConn);

                //set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                //execute the command that returns only one value. In your case the email that I presume it’s a string
                if (number == true)
                {
                    int SQLReturnedINT;
                    SQLReturnedINT = (int)sqlCommand.ExecuteScalar();
                    SQLReturn = SQLReturnedINT.ToString();
                }
                else
                {
                    SQLReturn = (String)sqlCommand.ExecuteScalar();
                }
            }
            sqlConn.Close();
            return SQLReturn;
        }
    }
}
