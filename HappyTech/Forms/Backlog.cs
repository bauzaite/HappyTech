using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech.Forms
{
    public partial class Backlog : Form
    {
        private object listFilesInDirectory;

        public Backlog()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

            MessageBox.Show(files.Count() + "files found");
        }
    }
}
