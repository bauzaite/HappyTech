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
        /*public static string basicRequest()
        {
            string answer = "";
            SqlConnection sqlConn;
            using (sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT * FROM Applicant_Information'";
                sqlCommand.Connection = sqlConn;
                sqlConn.Open();
                SqlDataReader rd = sqlCommand.ExecuteReader();
                while (rd.Read())
                {
                    //string id = rd["Applicant_Email"]);
                    string email = rd.GetValue(1).ToString();
                    //MessageBox.Show(hi);
                    MessageBox.Show("hello");
                    //MessageBox.Show(rd["Applicant_Email"].ToString());
                    string hoe = rd["Applicant_Email"].ToString();
                    MessageBox.Show(hoe);

                }
         
            }
            sqlConn.Close();
            return answer;
        }*/
    }
}
