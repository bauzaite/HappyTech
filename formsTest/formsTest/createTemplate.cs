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
    public partial class createTemplate : Form
    {
        public createTemplate()
        {
            InitializeComponent();
        }

        private void generateTemplate_Click(object sender, EventArgs e)
        {
            Template template = new Template(templateTitle.Text, templateText.Text);
            try
            {
                DatabaseConnection.saveToDb("INSERT INTO templates (templateTitle, templateText) VALUES(@templateTitle, @templateText)", template.templateTitle, template.templateText);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void createTemplate_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData() 
        {
            string sqlQuery = "SELECT * from templates";
            DataSet dataSet = DatabaseConnection.getData(sqlQuery);
            dgvDatabase2.DataSource = dataSet.Tables[0];
        }
    }
}
