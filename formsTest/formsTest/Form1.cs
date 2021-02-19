using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace formsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void GetCon_Click(object sender, EventArgs e)
        {
            constructor test = new constructor("CONSTRUCTOR 1", true);

            MessageBox.Show(Convert.ToString(test));

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void GetData_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT templateTitle, templateText FROM templates WHERE template_ID=16";
            DataSet dataSet = DatabaseConnection.getData(sqlQuery);
            dgvDatabase1.DataSource = dataSet.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
