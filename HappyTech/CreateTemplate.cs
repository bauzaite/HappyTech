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
    // TODO: The entered template isnt actually saved in the database.

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
                //set the value for the successful depending on if the radio button is checked
                int successfullOrUnsuccessful = 0;

                if (radioBTNTrue.Checked == true)
                {
                    successfullOrUnsuccessful = 1;

                }
                else if (radioBTNFalse.Checked == true)
                {
                    successfullOrUnsuccessful = 0;
                }

                //create template object to hold the parameters to be input into the DB
                Template template = new Template(templateTitle.Text, templateText.Text, templateCategorySelection.Text, successfullOrUnsuccessful);
                try
                {
                    //SQL insert statement
                    DatabaseConnection.createTemplate("INSERT INTO templates (templateTitle, templateText, templateCategory, templateSuccessful)" +
                        " VALUES(@templateTitle, @templateText, @templateCategory, @templateSuccessful)", template.templateTitle,
                        template.templateText, template.templateCategory, template.templateSuccessful);
                    MessageBox.Show("Template saved sucessfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
