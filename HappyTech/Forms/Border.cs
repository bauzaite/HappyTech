using HappyTech.Forms;
using System;
using System.Windows.Forms;

namespace HappyTech
{
    /// <summary>
    /// The Border Class provides a border-like UI where the user
    /// can select what form they want to access.
    /// </summary>
    public partial class Border : Form
    {
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
        /// Once user slelects 'Edit Template'
        /// the Edit Template page is shown
        /// </summary>
        private void showEditTemplate_Click(object sender, EventArgs e)
        {
            //display the create template page
            openNewForm(new EditTemplate());
        }
    }
}
