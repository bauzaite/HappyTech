using HappyTech.Forms;
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
    public partial class ManageTemplates : Form
    {
        public ManageTemplates()
        {
            InitializeComponent();
        }
        public static int templateChoice = 0;
        private void openNewForm(Form displayNewForm)
        {
            Border.panelMain.Controls.Clear();
            displayNewForm.TopLevel = false;
            displayNewForm.AutoScroll = true;
            Border.panelMain.Controls.Add(displayNewForm);
            displayNewForm.Dock = DockStyle.Fill;
            displayNewForm.Show();
        }
        private void editTemplate1_Click(object sender, EventArgs e)
        {
            //go to edit template
            templateChoice = 0;
            openNewForm(new EditTemplate());
        }
        private void editTemplate2_Click(object sender, EventArgs e)
        {
            //go to edit template
            templateChoice = 1;
            openNewForm(new EditTemplate());
        }
        private void editTemplate3_Click(object sender, EventArgs e)
        {
            //go to edit template
            templateChoice = 2;
            openNewForm(new EditTemplate());
        }
    }
}
