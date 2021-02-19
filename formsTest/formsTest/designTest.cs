using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsTest
{
    public partial class designTest : Form
    {
        public designTest()
        {
            InitializeComponent();
            Login login = new Login();
            login.TopLevel = false;
            login.AutoScroll = true;
            panel2.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            login.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form1 form1 = new Form1();
            form1.TopLevel = false;
            form1.AutoScroll = true;
            panel2.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }

        private void createTemplate_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            createTemplate createTemplate = new createTemplate();
            createTemplate.TopLevel = false;
            createTemplate.AutoScroll = true;
            panel2.Controls.Add(createTemplate);
            createTemplate.Dock = DockStyle.Fill;
            createTemplate.Show();
        }
    }
}
