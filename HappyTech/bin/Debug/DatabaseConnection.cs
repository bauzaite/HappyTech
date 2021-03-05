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

        /// WIP - VAIVA
        public static string basicRequest(string sqlQuery, bool number)
        {
            string name = "Error!";  // the string you want to display in the text box
            SqlConnection sqlConn;
            using (sqlConn = new SqlConnection(connectionString))
            {
                // Testing:
               // string sqlQuery = "SELECT Applicant_Email FROM Applicant_Information WHERE Applicant_info_id = 4";
               // string sqlQuery = "SELECT Applicant_info_ID FROM Applicant WHERE Applicant_Id = '1'";

                //open connection
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConn);
                //set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;
                //execute the command that returns only one value. In your case the email that I presume it’s a string

                if (number == true)
                {
                    int hi;
                    hi = (int)sqlCommand.ExecuteScalar();
                    name = hi.ToString();
                }
                else
                {
                    name = (String)sqlCommand.ExecuteScalar();
                }
            }
            sqlConn.Close();
            return name;
        }
    }
}
