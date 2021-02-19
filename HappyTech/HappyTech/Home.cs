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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            loginPassword.PasswordChar = '*';
        }
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string un = loginUsername.Text;
            string pwd = loginPassword.Text;
    
            //password comparison sql
            string sqlQuery = "SELECT * FROM employee WHERE employeeUN='" + un + "' AND employeePWD='" + pwd + "'";
            bool passCheck = DatabaseConnection.getCredentials(sqlQuery, un, pwd);

            if (passCheck == true)
            {
                //show main if password is true
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("LOGIN FAILURE");
            }
        }
    }
}
