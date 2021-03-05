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
    /// Home page gives user the option to select a applicant
    /// to create a email for.
    /// </summary>
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'applicant.Applicant' table.
            this.applicantTableAdapter.Fill(this.applicant.Applicant);
            
        }
        
        /// <summary>
        /// When user clicks on 'Review' button,
        /// the Home form is cleared and user is taken to the 'Choose Template' form.
        /// </summary>
        private void reviewButton_Click(object sender, EventArgs e)
        {
            Border.panelMain.Controls.Clear();
            chooseTemplate chooseTemp = new chooseTemplate();
            chooseTemp.TopLevel = false;
            chooseTemp.AutoScroll = true;
            Border.panelMain.Controls.Add(chooseTemp);
            chooseTemp.Dock = DockStyle.Fill;
            chooseTemp.Show();
        }
    }
}
