using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class createFeedback : Form
    {
        public createFeedback()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// onc user has selected checkboxes.
            /// save them and send into the richTextBox1
            /// in the richTextBox1 also add 'dear Applicant_Name,' + slected text boxes + 'yours sincerely, Employee_Name'
        }
       // string applicantID = DatabaseConnection.basicRequest("SELECT Applicant_info_ID FROM Applicant WHERE Applicant_Id = " + Home.applicantChoice.Text, true);
       // static string applicantInfo = DatabaseConnection.basicRequest("SELECT Applicant_fName FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false)
      //          + " " + DatabaseConnection.basicRequest("SELECT Applicant_lName FROM Applicant_Information WHERE Applicant_info_id = " + applicantID, false);
        private void createFeedback_Load(object sender, EventArgs e)
        {
            // TODO: depending on template clicked, the saved
            // sentances should be desplayed here. I am blocked atm
            generatedSentances.Items.Add("sentance1", false);
            generatedSentances.Items.Add("sentance2", false);
            generatedSentances.Items.Add("sentance3", false);
            generatedSentances.Items.Add("sentance4", false);
            generatedSentances.Items.Add("sentance5", false);

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

        }
        static string intro = "Dear Applicant Name";

        readonly string outro = "Yours Sincerely, \n UserName";

        /// <summary>
        /// Gets applicants information
        /// </summary>
        /// <returns></returns>
       // string get_email_info()
     //   {

      //      return "";
      //  }

        private void button1_Click(object sender, EventArgs e)
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

        private void saveEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your email has been saved! \nYou can find it and send it in the Backlog page.");
        }
    }
}
