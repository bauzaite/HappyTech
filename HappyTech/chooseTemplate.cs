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
    public partial class chooseTemplate : Form
    {
        public chooseTemplate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// WIP!!
        /// User gets displayed applicant information according to their choice.
        /// They also get displayed their templates they have saved.
        /// </summary>
        private void chooseTemplate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'happyTechDBDataSet2.templates' table. You can move, or remove it, as needed.
            this.templatesTableAdapter.Fill(this.happyTechDBDataSet2.templates);
            //sqlQuery = "SELECT * FROM Applicant_Information WHERE Applicant_info_id '2'";
            // TODO: This line of code loads data into the 'happyTechDBDataSet1.Applicant_Information' table. You can move, or remove it, as needed.
            this.applicant_InformationTableAdapter.Fill(this.happyTechDBDataSet1.Applicant_Information);

            string applicantID = Home.applicantChoice.Text; // this is the user choice of applicant save from the previosu Home window
            // SEND and an sql statement asking to retrieve the name of applicant
            //string sqlQuery = "SELECT * FROM Applicant_Information WHERE Applicant_info_id '" + applicantID + "'";
            //string name = DatabaseConnection.basicRequest(sqlQuery);
           // string sqlQuery = "SELECT Applicant_Email FROM Applicant_Information WHERE Applicant_info_id = '" + applicantID + "'";
           // DatabaseConnection.basicRequest();
            // then put it in the textbox below
            //applicantName.Text = info;
        }

        /// <summary>
        /// Test code
        /// TODO: Delete in the end
        /// </summary>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("applicant choice was " + Home.applicantChoice.Text);
            string myString = "applicant choice was " + Home.applicantChoice.Text;
            applicantName.Text = myString;
        }

    }
}
