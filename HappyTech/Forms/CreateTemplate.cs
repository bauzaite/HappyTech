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

        int saveCount = 0;
        string templateID;
        private void submitTemplateBTN_Click(object sender, EventArgs e)
        {
            // if clicked save 1 time
            // 
            saveCount++;
            if (saveCount == 1)
            {
                // if you are saving template for first time.
                // save template_ID of the new template
                templateID = DatabaseConnection.insertData(@"INSERT INTO Template (Template_title, Template_owner) VALUES ('" + templateTitle.Text + "','" + Login.loggedInEmployee + "' ); SELECT CAST(scope_identity() AS int)", true);
                // save the new text
                string ignore = DatabaseConnection.insertData(@"INSERT INTO Template (Template_text, Template_owner) VALUES ('" + templateText.Text + "','" + Login.loggedInEmployee + "' ); SELECT CAST(scope_identity() AS int)", true);
                // lock title so user cannot edit it
                templateTitle.ReadOnly = true;
            }
            else
            {
                // this means you saved template already
                // then u have to use the existing templateID
                string ignore = DatabaseConnection.insertData(@"INSERT INTO Template (Template_text, Template_owner) VALUES ('" + templateText.Text + "','" + Login.loggedInEmployee + "' ); SELECT CAST(scope_identity() AS int)", true);
                // save title
                string id = DatabaseConnection.insertData(@"INSERT INTO Template (Template_title, Template_owner) VALUES ('" + templateTitle.Text + "','" + Login.loggedInEmployee + "' ); SELECT CAST(scope_identity() AS int)", true); // && return its ID
                //DatabaseConnection.insertData(@"INSERT INTO Template (Template_owner) VALUES ('" + Login.loggedInEmployee +"'", true);
                // Inside of db.Text, save the users inputted sentence and save the template_ID against it
                //string ignore = DatabaseConnection.insertData(@"INSERT INTO Text (Text, Template_ID) VALUES ('" + templateText.Text + "', (SELECT Template_ID from Template WHERE Template_ID ='" + id + "'))", false);
            }

            peviewTemplateTitle.Text = templateTitle.Text;
            string[] list1 = new string[3];
            list1 = DatabaseConnection.basicRequestArray();
            previewTemplateText.Items.Add(list1[0]);
            previewTemplateText.Items.Add(list1[1]);
            previewTemplateText.Items.Add(list1[2]);
            // SECOMND ISSUE - THIS IS RETURNING 3 COLUMNS HOW DO I HANDLE THAT
            // string textCount = DatabaseConnection.basicRequest("SELECT COUNT(Text) FROM Text WHERE Template_ID = " + templateID, true);
            // for (int i = 0; i < int.Parse(textCount); i++)
            // {
            //     previewTemplateText.Items.Add(text);
            //SELECT COUNT(Text) FROM Text WHERE Template_ID = 108
            // }


            // string text = DatabaseConnection.basicRequest("SELECT Text FROM Text WHERE Template_ID = " + templateID, false);
            //MessageBox.Show("Template saved sucessfully: \n " + text);

            //previewTemplateText.Items.Add(text);
            //print the stored information into the BoxList
            // 1 - count how many Text has been saved with the Template_ID
            // 2 - iterate over each Text with Template_ID
            // 3 - add to BoxList
        }

        private void fillText()
        {

        }
    }
}
