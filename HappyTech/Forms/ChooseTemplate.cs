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
            int count = Int32.Parse(DatabaseConnection.Instance().basicRequest("SELECT COUNT(Template_title) FROM Template WHERE Template_Owner = '"
                                    + Login.loggedInEmployee + "'", true));

            // Check if the user has saved templates
            if (count != 0)
            {
                // Load Template choices
                Helper.fillUserList("Template", "Template_title", "Template_Owner", Login.loggedInEmployee, templateChoice, false);

                // Load Applicant Information
                Helper.LoadApllicantInformation(applicantName, applicantEmail, applicantStage, applicantSuccessful,
                                                Home.applicantRefrenceChoices.Text.ToString());
            }
            else
            {
                MessageBox.Show("Please create a template in the 'Create Template' page.");
            }
        }

        /// <summary>
        /// Takes user to the 'Create Feedback' Form
        /// </summary>
        private void nextStep_Click(object sender, EventArgs e)
        {
            // check user has selected an applicant
            if (templateChoice.Text.ToString() != "")
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
            else
            {
                MessageBox.Show("Please select a template.");
            }
        }
    }
}
