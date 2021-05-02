using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace HappyTech.Forms
{
    public partial class Backlog : Form
    {
        public Backlog()
        {
            InitializeComponent();

            //When entering password it will be invisible for others
            //the password is: Wunderland2021
            userPass.PasswordChar = '*';
        }        

        private void browseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            txtDirectory.Text = dlg.SelectedPath;
        }

        /// <summary>
        /// Browse for the directory where the PDF's are stored
        /// List all PDF feedback files in Message Box
        /// *.* for all types
        /// </summary>        
        private void showFilesBtn_Click(object sender, EventArgs e)
        {
            var files = System.IO.Directory.GetFiles(txtDirectory.Text, 
                "*.*", System.IO.SearchOption.AllDirectories);

            lstFiles.DataSource = files;

            MessageBox.Show(files.Count() + " files found");
        }

        /// <summary>
        /// Creating a SMTP server which enables sending emails from the app
        /// Port 587 allows you to use SSL connection
        /// Smtp server = smtp.gmail.com if using gmail addresses
        /// Let's you to select one file and attach to the email
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage email = new MailMessage(fromEmail.Text, toEmail.Text);

            //this line will allow you to select one of the selected files from the list box
            //and send it to selected email address
            email.Attachments.Add(new Attachment((string)lstFiles.SelectedItem));
                       
            SmtpClient client = new SmtpClient(smtpServer.Text);

            client.Port = 587;
            client.Credentials = new NetworkCredential(userName.Text, userPass.Text);
            client.EnableSsl = true;
            client.Send(email);

            //Messagebox to let the user now that email has been sent out
            MessageBox.Show("The selected file has been attached and the email has been sent out!", "Success", MessageBoxButtons.OK);                                   
        }
    }
}