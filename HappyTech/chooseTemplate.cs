using System;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class chooseTemplate : Form
    {
        /// <summary>
        /// Here user is diplayed the applicants detais,
        /// and can choose template they have save earlier 
        /// to use to reply to their apllicant in the next form.
        /// </summary>
        public chooseTemplate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User gets displayed applicant information according to their choice.
        /// They also get displayed their templates they have saved.
        /// </summary>
        private void chooseTemplate_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'happyTechDBDataSet10.templates' table.
            this.templatesTableAdapter3.Fill(this.happyTechDBDataSet10.templates);

            /// LOAD APPLICANT INFO
            // get applicant_info_ID by taking the applicant_ID that user selected
            string applicantID = DatabaseConnection.basicRequest("SELECT Applicant_info_ID FROM Applicant WHERE Applicant_Id = " + Home.applicantChoice.Text, true);

            // Request Applicant_fName and Applicant_lName depending on the applicant_info_ID
            applicantName.Text = DatabaseConnection.basicRequest("SELECT Applicant_fName FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false)
                + " " + DatabaseConnection.basicRequest("SELECT Applicant_lName FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);

            // Request Applicant_Email depending on the applicant_info_ID
            applicantEmail.Text = DatabaseConnection.basicRequest("SELECT Applicant_Email FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);

            // Request Applicant_Stage depending on the applicant_info_ID
            applicantStage.Text = DatabaseConnection.basicRequest("SELECT Applicant_Stage FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);

            // Request Applicant_Successful depending on the applicant_info_ID
            applicantSuccessful.Text = DatabaseConnection.basicRequest("SELECT Applicant_Successful FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);
        }

        /// <summary>
        /// Takes user to the 'Create Feedback' Form
        /// </summary>
        private void nextStep_Click(object sender, EventArgs e)
        {
            // take user to the next step
            Border.panelMain.Controls.Clear();
            createFeedback createFeed = new createFeedback();
            createFeed.TopLevel = false;
            createFeed.AutoScroll = true;
            Border.panelMain.Controls.Add(createFeed);
            createFeed.Dock = DockStyle.Fill;
            createFeed.Show();
        }
    }
}
