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
       static string intro;
       readonly string outro = "Yours Sincerely, \n " + Login.loggedInEmployee.ToString();

        public createFeedback()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads information about the applicant and loads sentances into a
        /// BoxList from the chosen template that the user selected in the previous form.
        /// </summary>
        private void createFeedback_Load(object sender, EventArgs e)
        {
            // Find template_ID of the chosen template
            int templateID = Int32.Parse(DatabaseConnection.Instance().basicRequest("SELECT Template_ID FROM Template WHERE Template_title = '" + chooseTemplate.templateChoice.Text + "'", true));

            // Load Saved sentances from the chosen template
            Helper.fillUserList("Text", "Text", "Template_ID", templateID.ToString(), generatedSentances, false);

            // Load information about the applicant
            Helper.LoadApllicantInformation(applicantName, applicantEmail, applicantStage, applicantSuccessful, Home.applicantRefrenceChoices.Text.ToString());

            intro = "Dear " + applicantName.Text.ToString() + ",";
        }

        /// <summary>
        /// When button with 'Add To Email' is clicked,
        /// the email textbox is filled with the users checked text from
        /// the checkboxlist and a intro and outro is added to it.
        /// </summary>
        private void addToEmail_Click(object sender, EventArgs e)
        {
            // check user has selected sentances
            if (generatedSentances.SelectedItems.Count != 0)
            {
                string emailContent = "";
                // Each sentances user has selected, add it it to the email.
                for (int x = 0; x < generatedSentances.SelectedItems.Count; x++)
                {
                    emailContent = emailContent + generatedSentances.SelectedItems[x].ToString() + " ";
                }
                email.Text = intro + "\n\n" + emailContent + "\n\n" + outro;
            }
            else
            {
                MessageBox.Show("Please choose text to fill email");
            }
        }

        /// <summary>
        /// Once user is happy with their email, they click 'Save' and
        /// the email is saved in the database and can be later viewed in
        /// the backlog
        /// </summary>
        private void emailInBacklog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your email has been saved! You can find it in the 'Backlog' page.");
        }
    }
}
