using System;
using System.Windows.Forms;

namespace HappyTech
{
    /// <summary>
    /// This is where user can choose from the saved sentaces
    /// to automatically write an email.
    /// </summary>
    public partial class createFeedback : Form
    {
        static string applicantNames;
        static string intro;
        readonly string outro = "Yours Sincerely, \n UserName";

        public createFeedback()
        {
            InitializeComponent();
        }

        // TODO: MAKE SURE USER CANT SAVE 2 OF THE SAME TEMPLATE TITLES
        // TODO: SAV THE USER NAME AND ADD IT TO THE EMAIL
        // BUG: MAKE SURE USER STORES 5 SENTANCES, OR, IF THEY DONT MAKE SURE 'EMPTY' OR SOMTHING IS STORED IN THAT COLUMN

        /// <summary>
        /// Loads information about the applicant and loads sentances into a
        /// checkboxlist from the chosen template that the user selected in the
        /// previous form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createFeedback_Load(object sender, EventArgs e)
        {
            // Fill the checkboxlist with saved sentances from chosen template by the user.
            string templateID = DatabaseConnection.basicRequest("SELECT Id FROM templates WHERE templateTitle = '" + chooseTemplate.templateChoice.Text + "'", true);
            string text1 = DatabaseConnection.basicRequest("SELECT templateText_1 FROM templates WHERE Id = " + templateID, false);
            string text2 = DatabaseConnection.basicRequest("SELECT templateText_2 FROM templates WHERE Id = " + templateID, false);
            string text3 = DatabaseConnection.basicRequest("SELECT templateText_3 FROM templates WHERE Id = " + templateID, false);
            string text4 = DatabaseConnection.basicRequest("SELECT templateText_4 FROM templates WHERE Id = " + templateID, false);
            string text5 = DatabaseConnection.basicRequest("SELECT templateText_5 FROM templates WHERE Id = " + templateID, false);
            generatedSentances.Items.Add(text1, false);
            generatedSentances.Items.Add(text2, false);
            generatedSentances.Items.Add(text3, false);
            generatedSentances.Items.Add(text4, false);
            generatedSentances.Items.Add(text5, false);

            // Get the user applicant choice - and find that applicants ID that is saved in Applicant_Information
            string applicantID = DatabaseConnection.basicRequest("SELECT Applicant_info_ID FROM Applicant WHERE Applicant_Id = " + Home.applicantChoice.Text, true);

            // Display all of that applicants information into the textboxes in the form.
            applicantName.Text = DatabaseConnection.basicRequest("SELECT Applicant_fName FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false)
                                                                  + " " + DatabaseConnection.basicRequest("SELECT Applicant_lName FROM Applicant_Information WHERE Applicant_info_id = "
                                                                  + applicantID, false);
            applicantEmail.Text = DatabaseConnection.basicRequest("SELECT Applicant_Email FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);
            applicantStage.Text = DatabaseConnection.basicRequest("SELECT Applicant_Stage FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);
            applicantSuccessful.Text = DatabaseConnection.basicRequest("SELECT Applicant_Successful FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);

            // Request for the username;
            // Save
            applicantNames = applicantName.Text.ToString();
            intro = "Dear " + applicantNames + ",";
        }

        /// <summary>
        /// When button with 'Add To Email' is clicked,
        /// the email textbox is filled with the users checked text from
        /// the checkboxlist and a intro and outro is added to it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToEmail_Click(object sender, EventArgs e)
        {
            // MessageBox.Show( generatedSentances.CheckedItems.ToString());
            if (generatedSentances.CheckedItems.Count != 0)
            {
                string s = "";
                for (int x = 0; x < generatedSentances.CheckedItems.Count; x++)
                {
                    s = s + generatedSentances.CheckedItems[x].ToString() + " ";
                }
                //MessageBox.Show(s);
                email.Text = intro + "\n\n" + s + "\n\n" + outro;
            }
            else
            {
                MessageBox.Show("Please choose text to fill email");
            }
        }
    }
}
