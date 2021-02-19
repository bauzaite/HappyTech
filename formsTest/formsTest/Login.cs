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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loginPassword.PasswordChar = '*';
        }
        private void login_BTN_Click(object sender, EventArgs e)
        {
            string un = loginUsername.Text;
            string pwd = loginPassword.Text;

            string sqlQuery = "SELECT * FROM employee WHERE employeeUN='" + un + "' AND employeePWD='"+ pwd +"'";
            bool passCheck = DatabaseConnection.getCredentials(sqlQuery, un, pwd);

            if (passCheck == true)
            {
                MessageBox.Show("LOGIN SUCCESS");
            }
            else 
            {
                MessageBox.Show("LOGIN FAILURE");
            }
        }
    }
}
