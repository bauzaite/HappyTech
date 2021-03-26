using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech.Forms
{
    public partial class EditTemplate : Form
    {
        public EditTemplate()
        {
            InitializeComponent();
            List<Template> userTemplates = new List<Template>();
            string sqlQuery = "SELECT * FROM Template WHERE Template_owner = '" + Login.loggedInEmployee + "'";
            userTemplates = DatabaseConnection.getTemplates(sqlQuery);
            templateTitle.Text = userTemplates[ManageTemplates.templateChoice].templateTitle;
            templateText.Text = userTemplates[ManageTemplates.templateChoice].templateText;
        }
        private void updateTemplateBTN_Click(object sender, EventArgs e)
        {
            //Add SQL update function in DBconnection.
            //UPDATE templates SET templateTitle = templateTitle.Text etc
        }
    }
}
