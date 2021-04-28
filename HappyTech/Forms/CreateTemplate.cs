using System;
using System.Windows.Forms;

namespace HappyTech
{
    /// <summary>
    /// This is where the user gets to create a template.
    /// The template is saved into the database.
    /// </summary>
    public partial class CreateTemplate : Form
    {
        public CreateTemplate()
        {
            InitializeComponent();
        }

        int saveCount = 0;
        public static string templateID;

        /// <summary>
        /// The 'Save' button saves new templates title and assigned text(s) depending on whether the templates title is unique.
        /// It then shows user what they have saved in the database.
        /// </summary>
        private void submitTemplateBTN_Click(object sender, EventArgs e)
        {
            saveCount++;
            bool titleExists = DatabaseConnection.checkDataExists("SELECT Template_title FROM Template WHERE Template_title = '"
                                                                  + templateTitle.Text + "'");

             // If you are creating a new template AND the title is unique.
            if (saveCount == 1 && titleExists == false)
            {
                // Create a new template by saving its title and creators username. Save the new assigned Template_ID by the database.
                templateID = DatabaseConnection.insertDataScalar(@"INSERT INTO Template (Template_title, Template_owner) VALUES ('"
                                                                 + templateTitle.Text + "','" + Login.loggedInEmployee + "' );" +
                                                                 "SELECT CAST(scope_identity() AS int)");

                // Save the new saved Text and assign the template_ID to it.
                DatabaseConnection.insertDataNonQuery(@"INSERT INTO Text (Text, Template_ID) VALUES ('" + templateText.Text + "'," +
                                                      " (SELECT Template_ID from Template WHERE Template_ID ='" + templateID + "'))");
            }
            // If you are creating a new template AND the title isnt unique.
            else if (saveCount == 1 && titleExists == true)
            {
                MessageBox.Show("Title Name already exists. Please enter a different title.");
            }
            // If you have already have started creating a new template AND the template exists.
            else if (saveCount >= 2 && titleExists == true)
            {
                // Don't allow user to edit the title.
                templateTitle.ReadOnly = true; // Makes program more clear since the user can only keep saving sentances to the same template

                // Save the new saved Text and assign the template_ID to it.
                DatabaseConnection.insertDataNonQuery(@"INSERT INTO Text (Text, Template_ID) VALUES ('" + templateText.Text + "'," +
                                                      " (SELECT Template_ID from Template WHERE Template_ID ='" + templateID + "'))");
            }
            else
            {
                MessageBox.Show("Error");
            }

            // Fill preview ListBox
            peviewTemplateTitle.Text = templateTitle.Text;
            Helper.fillUserList("Text", "Text", "Template_ID", templateID, previewTemplateText, true);
        }
    }
}
