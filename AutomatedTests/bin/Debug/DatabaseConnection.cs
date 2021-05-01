using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HappyTech
{
    /// <summary>
    ///  This class creates a connection with the database
    ///  and sends requests to it.
    /// </summary>
    public class DatabaseConnection
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

        // This applicant constuctor should be acessible by all forms.
        public static Applicant applicant;
        /// <summary>
        /// Fills applicant constructor with the relevant applicants information.
        /// </summary>
        /// <param name="sqlQuery">SQL Command giving the relevant applicants identification.</param>
        public static void loadApplicantInformation(string sqlQuery)
        {
            SqlConnection sqlCon;
            using (sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        applicant = new Applicant
                        {
                            applicantFName = reader["Applicant_fName"].ToString(),
                            applicantLName = reader["Applicant_lName"].ToString(),
                            applicantEmail = reader["Applicant_Email"].ToString(),
                            applicantStage = reader["Applicant_Stage"].ToString(),
                            applicantSuccessful = reader["Applicant_Successful"].ToString()
                        };
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                reader.Close();
            }
        }

        /// <summary>
        /// Execute an insert data SQL command and expect a return.
        /// </summary>
        /// <param name="sqlQuery">Requests for specific data in column.</param>
        /// <returns>Requested data from the SQL Command</returns>
        public static string insertDataScalar(string sqlQuery)
        {
            int id = 0;
            SqlConnection sc;
            using (sc = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand();
                sc.Open();

                com.Connection = sc;
                com.CommandText = (sqlQuery);
                id = (int)com.ExecuteScalar();
                sc.Close();
            }
            return id.ToString();
        }
        /// <summary>
        /// Execute an insert data SQL command and dont expect a return.
        /// </summary>
        /// <param name="sqlQuery">Requests for specific data in column.</param>
        public static void insertDataNonQuery(string sqlQuery)
        {
            SqlConnection sc;
            using (sc = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand();
                sc.Open();
                com.Connection = sc;
                com.CommandText = (sqlQuery);
                com.ExecuteNonQuery();
                sc.Close();
            }
        }
        public static List<Template> getTemplates(string sqlQuery)
        {
            List<Template> tempList = new List<Template>();
            SqlConnection sqlCon;
            using (sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        Template template = new Template
                        {
                            templateTitle = reader["Template_title"].ToString(),
                            templateOwner = reader["Template_owner"].ToString()
                        };
                        tempList.Add(template);
                    }
                    catch(Exception exc) 
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                reader.Close();
            }
            return tempList;
        }

        /// <summary>
        /// Using sent SQL Command, check data exists in the DB.
        /// </summary>
        /// <param name="sqlQuery">Requests for specific data in column.</param>
        /// <returns></returns>
        public static bool checkDataExists(string sqlQuery)
        {
            bool check;
            SqlConnection sqlCon;
            using (sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlCon);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    check = true;
                    reader.Close();
                }
                else
                {
                    check = false;
                    reader.Close();
                }
            }
            return check;
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

        /// <summary>
        /// This is the same as basicRequest() but an array of requested data
        /// is returned instead.
        /// </summary>
        /// <param name="sqlQuery">SQL Command sent to  the Database</param>
        /// <param name="count">How big is the array</param>
        /// <returns>Array of requested data</returns>
        public static string[] basicRequestArray(string sqlQuery, int count)
        {
            string[] requestedArray = new string[count];
            //sqlQuery = "SELECT Text FROM Text WHERE Template_ID = 158";
            SqlConnection sqlConn;
            using (sqlConn = new SqlConnection(connectionString))
            {
                //open connection
                sqlConn.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConn);
                sqlCommand.CommandType = CommandType.Text;
                SqlDataReader dataReader = sqlCommand.ExecuteReader();


                // iterate over each row and save it in the array
                for (int i = 0; i < count; i++)
                {
                    dataReader.Read();
                    requestedArray[i] = dataReader[0].ToString();
                }
            }
            sqlConn.Close();
            return requestedArray;
        }
    }
}
