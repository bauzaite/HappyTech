using System;
using System.Windows.Forms;

namespace HappyTech
{
    /// <summary>
    /// First form the user gets displayed.
    /// This is the login form where user
    /// gets propmpted for their username and password.
    /// </summary>
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loginPassword.PasswordChar = '*';
        }

        /// <summary>
        /// Once user has clicked the 'Login' button
        /// their imput is sent to database and checked.
        /// If successful, they enter the next form.
        /// </summary>
        public static string loggedInEmployee = "";
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string un = loginUsername.Text;
            string pwd = loginPassword.Text;
    
            // Password comparison sql
            string sqlQuery = "SELECT * FROM employee WHERE employeeUN='" + un + "' AND employeePWD='" + pwd + "'";
            bool passCheck = DatabaseConnection.getCredentials(sqlQuery);

            if (passCheck == true)
            {
                // Show border if password is true
                Border Border = new Border();
                Border.Show();
                this.Hide();
                loggedInEmployee = un;
            }
            else
            {
                MessageBox.Show("LOGIN FAILURE");
            }
        }
    }
}
