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
    // TODO: Add some sort of welcome message so it not just a blank screen

    /// <summary>
    /// The Border Class provides a border-like UI where the user
    /// can select what form they want to access.
    /// </summary>
    public partial class Border : Form
    {
        // TODO: Could this repeated code be automated?
        private void openNewForm(Form displayNewForm)
        {
            panelMain.Controls.Clear();
            displayNewForm.TopLevel = false;
            displayNewForm.AutoScroll = true;
            panelMain.Controls.Add(displayNewForm);
            displayNewForm.Dock = DockStyle.Fill;
            displayNewForm.Show();
        }
        public Border()
        {
            InitializeComponent();
            openNewForm(new Home());
        }
        /// <summary>
        /// Once user slelects 'Home'
        /// the Home page is shown
        /// </summary>
        private void showHome_Click(object sender, EventArgs e)
        {
            //display the home page
            openNewForm(new Home());
        }
        /// <summary>
        /// When user selects to 'Create Template'
        /// the CreateTemplate form is shown.
        /// </summary>
        private void showCreateTemplate_Click(object sender, EventArgs e)
        {
            //display the create template page
            openNewForm(new CreateTemplate());
        }
        /// <summary>
        /// When user selects to 'Manage Templates'
        /// the ManageTemplates form is shown.
        /// </summary>
        private void showManageTemplates_Click(object sender, EventArgs e)
        {
            //display the manage templates page
            openNewForm(new ManageTemplates());
        }
    }
}
