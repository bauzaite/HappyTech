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
        public Border()
        {
            InitializeComponent();
        }

        // TODO: Could this repeated code be automated?

        /// <summary>
        /// When user selects to 'Create Template'
        /// the CreateTemplate form is shown.
        /// </summary>
        private void showCreateTemplate_Click(object sender, EventArgs e)
        {
            //clear the panel to display the create template page
            panelMain.Controls.Clear();
            CreateTemplate createTemplate = new CreateTemplate();
            createTemplate.TopLevel = false;
            createTemplate.AutoScroll = true;
            panelMain.Controls.Add(createTemplate);
            createTemplate.Dock = DockStyle.Fill;
            createTemplate.Show();
        }

        /// <summary>
        /// Once user slelects 'Home'
        /// the Home page is shown
        /// </summary>
        private void showHome_Click(object sender, EventArgs e)
        {
            //clear the panel to display the home page
            panelMain.Controls.Clear();
            Home home = new Home();
            home.TopLevel = false;
            home.AutoScroll = true;
            panelMain.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.Show();
        }
    }
}
