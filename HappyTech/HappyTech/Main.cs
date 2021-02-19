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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

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
    }
}
