using System;
using System.Windows.Forms;

namespace HappyTech
{
    /// <summary>
    /// Home page gives user the option to select a applicant
    /// to create a email for.
    /// </summary>
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the 'Home' form with information with applicans.
        /// </summary>
        private void Home_Load(object sender, EventArgs e)
        {
            int count = Int32.Parse(DatabaseConnection.basicRequest("SELECT COUNT(Applicant_Refrence) FROM Applicant_Information", true));

            if (count != 0){
                string[] applicantRefrences = new string[count];
                // Fill the templates array with template_text
                DatabaseConnection.basicRequestArray("SELECT Applicant_Refrence FROM Applicant_Information", count).CopyTo(applicantRefrences, 0);

                // Fill the ListBox with all availible templates
                for (int i = 0; i < count; i++)
                {
                    applicantRefrenceChoices.Items.Add(applicantRefrences[i]);
                }
            }
            else
            {
                MessageBox.Show("You have no applicants to respond to!");
            }
        }
       
        /// <summary>
        /// When user clicks on 'Review' button,
        /// the Home form is cleared and user is taken to the 'Choose Template' form.
        /// </summary>
        private void reviewButton_Click(object sender, EventArgs e)
        {
            // check user has selected an applicant
            if (applicantRefrenceChoices.Text.ToString() != "")
            {
                Border.panelMain.Controls.Clear();
                chooseTemplate chooseTemp = new chooseTemplate();
                chooseTemp.TopLevel = false;
                chooseTemp.AutoScroll = true;
                Border.panelMain.Controls.Add(chooseTemp);
                chooseTemp.Dock = DockStyle.Fill;
                chooseTemp.Show();
            }
            else
            {
                MessageBox.Show("Please select an applicant.");
            }
        }
    }
}
