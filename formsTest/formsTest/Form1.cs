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
            DataSet dataSet = DatabaseConnection.getDatabaseConnection().getData();
            dgvDatabase1.DataSource = dataSet.Tables[0];
        }
    }
}
