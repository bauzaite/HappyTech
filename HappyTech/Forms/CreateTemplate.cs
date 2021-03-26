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

        private void submitTemplateBTN_Click(object sender, EventArgs e)
        {
            {
                // make sure the tile box cannot be changed anoymore
                templateTitle.ReadOnly = true;

                // save title
                string id = DatabaseConnection.insertData(@"INSERT INTO Template (Template_title, Template_owner) VALUES ('" + templateTitle.Text + "','" + Login.loggedInEmployee + "' ); SELECT CAST(scope_identity() AS int)", true); // && return its ID
                //DatabaseConnection.insertData(@"INSERT INTO Template (Template_owner) VALUES ('" + Login.loggedInEmployee +"'", true);
                // Inside of db.Text, save the users inputted sentence and save the template_ID against it
                string ignore = DatabaseConnection.insertData(@"INSERT INTO Text (Text, Template_ID) VALUES ('" + templateText.Text + "', (SELECT Template_ID from Template WHERE Template_ID ='" + id + "'))", false);

                // Show user their saved template
                // Title
                peviewTemplateTitle.Text = templateTitle.Text;
                // Text
                // SECOMND ISSUE - THIS IS RETURNING 3 COLUMNS HOW DO I HANDLE THAT
                string text = DatabaseConnection.basicRequest("SELECT Text FROM Text WHERE Template_ID = " + id, false);
                //MessageBox.Show("Template saved sucessfully: \n " + text);

                previewTemplateText.Items.Add(text);
                //print the stored information into the BoxList
                // 1 - count how many Text has been saved with the Template_ID
                // 2 - iterate over each Text with Template_ID
                // 3 - add to BoxList
            }
        }
    }
}
