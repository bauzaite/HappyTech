using System;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class createFeedback : Form
    {
        /// <summary>
        /// This is where user can choose from the saved sentaces
        /// to automatically write an email.
        /// </summary>
        public createFeedback()
        {
            InitializeComponent();
        }

        static string applicantNames;
        static string intro;
        private void createFeedback_Load(object sender, EventArgs e)
        {
            string templateID = DatabaseConnection.basicRequest("SELECT Id FROM templates WHERE templateTitle = '" + chooseTemplate.templateChoice.Text + "'", true);
            /// GET userID and templateChoice => get the sentances
            string text1 = DatabaseConnection.basicRequest("SELECT templateText_1 FROM templates WHERE Id = " + templateID, false);
            //MessageBox.Show(text1);

            // TODO: MAKE SURE USER CANT SAVE 2 OF THE SAME TEMPLATE TITLES
            // BUG: MAKE SURE USER STORES 5 SENTANCES, OR, IF THEY DONT MAKE SURE 'EMPTY' OR SOMTHING IS STORED IN THAT COLUMN

            string text2 = DatabaseConnection.basicRequest("SELECT templateText_2 FROM templates WHERE Id = " + templateID, false);
            string text3 = DatabaseConnection.basicRequest("SELECT templateText_3 FROM templates WHERE Id = " + templateID, false);
            string text4 = DatabaseConnection.basicRequest("SELECT templateText_4 FROM templates WHERE Id = " + templateID, false);
            string text5 = DatabaseConnection.basicRequest("SELECT templateText_5 FROM templates WHERE Id = " + templateID, false);

            // TODO: depending on template clicked, the saved
            // sentances should be desplayed here. I am blocked atm
            generatedSentances.Items.Add(text1, false);
            generatedSentances.Items.Add(text2, false);
            generatedSentances.Items.Add(text3, false);
            generatedSentances.Items.Add(text4, false);
            generatedSentances.Items.Add(text5, false);

            // load applicant info
            // make applicantName and userName public variables
            string applicantID = DatabaseConnection.basicRequest("SELECT Applicant_info_ID FROM Applicant WHERE Applicant_Id = " + Home.applicantChoice.Text, true);

            // Request Applicant_fName and Applicant_lName depending on the applicant_info_ID
            applicantName.Text = DatabaseConnection.basicRequest("SELECT Applicant_fName FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false)
                + " " + DatabaseConnection.basicRequest("SELECT Applicant_lName FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);
            //applicantName.Text = applicantInfo;

            // Request Applicant_Email depending on the applicant_info_ID
            applicantEmail.Text = DatabaseConnection.basicRequest("SELECT Applicant_Email FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);

            // Request Applicant_Stage depending on the applicant_info_ID
            applicantStage.Text = DatabaseConnection.basicRequest("SELECT Applicant_Stage FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);

            // Request Applicant_Successful depending on the applicant_info_ID
            applicantSuccessful.Text = DatabaseConnection.basicRequest("SELECT Applicant_Successful FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);

            // Request for the userID;


            // Add to intro
            applicantNames = applicantName.Text.ToString();
            intro = "Dear " + applicantNames + ",";

        }

        readonly string outro = "Yours Sincerely, \n UserName";

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
