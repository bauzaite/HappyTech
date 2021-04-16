using System;
using System.Windows.Forms;

namespace HappyTech
{
    /// <summary>
    /// This is a Helper file that holds useful methods for forms to use.
    /// </summary>
    class Helper
    {
        public static int count;
        /// <summary>
        /// Loads relevant applicant information into specified textboxes inside a form
        /// </summary>
        /// <param name="name">TextBox that holds applicants name</param>
        /// <param name="email">TextBox that holds applicants email</param>
        /// <param name="stage">TextBox that holds applicants stage</param>
        /// <param name="successful">TextBox that holds applicants current stage success</param>
        /// <param name="applicantIdentity">Which applicants data to return</param>
        public static void LoadApllicantInformation(TextBox name, TextBox email, TextBox stage, TextBox successful, string applicantIdentity)
        {
            count++;
            // If the Applicant constructor hasn't been filled with the information yet
            if (count == 1)
            {
                // Send data request to the database and fill the constructor
                string sqlQuery = "SELECT * FROM Applicant_Information WHERE Applicant_Refrence = '" + applicantIdentity + "'";
                DatabaseConnection.loadApplicantInformation(sqlQuery);
            }

            // Fill the given textboxes with the information
            name.Text = DatabaseConnection.applicant.applicantFName + " " + DatabaseConnection.applicant.applicantLName;
            email.Text = DatabaseConnection.applicant.applicantEmail;
            stage.Text = DatabaseConnection.applicant.applicantStage;
            successful.Text = DatabaseConnection.applicant.applicantSuccessful;
        }

        /// <summary>
        /// Fills a ListBox in a form with specified data from the database.
        /// </summary>
        /// <param name="table">Specified table from DB</param>
        /// <param name="column">What data to fill sent ListBox with </param>
        /// <param name="columnID">Column constraint that ensures correct data from the column is saved</param>
        /// <param name="ID">The identification data for columnID</param>
        /// <param name="list">The ListBox to be filled in the form</param>
        /// <param name="clearlist">Option for user to clear BoxList after every call</param>
        public static void fillUserList(string table, string column, string columnID, string ID, ListBox list, bool clearlist)
        {
            // Count how many columns there are with a specific column identification
            int count = Int32.Parse(DatabaseConnection.basicRequest("SELECT COUNT(" + column +") FROM "+ table +" WHERE " + columnID + " = '" + ID + "'", true));
            string[] requestedColumnData = new string[count];

            // Fill the array with the specified column identification
            DatabaseConnection.basicRequestArray("SELECT " + column + " FROM " + table + " WHERE " + columnID + " = '" + ID + "'", count).CopyTo(requestedColumnData, 0);

            // Clear old data from sent list?
            if (clearlist == true)
            {
                list.Items.Clear();
            }

            // Fill the sent list with the specified column identification array
            for (int i = 0; i < count; i++)
            {
                list.Items.Add(requestedColumnData[i]);
            }
        }
    }
}
