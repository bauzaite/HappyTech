
namespace HappyTech.Forms
{
    partial class Backlog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.showFilesBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromEmail = new System.Windows.Forms.TextBox();
            this.toEmail = new System.Windows.Forms.TextBox();
            this.smtpServer = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.userPass = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(378, 141);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.ScrollAlwaysVisible = true;
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFiles.Size = new System.Drawing.Size(355, 251);
            this.lstFiles.TabIndex = 0;
            
            // 
            // showFilesBtn
            // 
            this.showFilesBtn.Location = new System.Drawing.Point(109, 98);
            this.showFilesBtn.Name = "showFilesBtn";
            this.showFilesBtn.Size = new System.Drawing.Size(75, 23);
            this.showFilesBtn.TabIndex = 1;
            this.showFilesBtn.Text = "Show Files";
            this.showFilesBtn.UseVisualStyleBackColor = true;
            this.showFilesBtn.Click += new System.EventHandler(this.showFilesBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(28, 97);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(190, 100);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(543, 20);
            this.txtDirectory.TabIndex = 3;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 80);
            this.panelTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(400, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backlog";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(658, 407);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Smtp Server:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password:";
            // 
            // fromEmail
            // 
            this.fromEmail.Location = new System.Drawing.Point(190, 141);
            this.fromEmail.Name = "fromEmail";
            this.fromEmail.Size = new System.Drawing.Size(182, 20);
            this.fromEmail.TabIndex = 11;
            this.fromEmail.Text = "happytechtesting@gmail.com";
            // 
            // toEmail
            // 
            this.toEmail.Location = new System.Drawing.Point(190, 167);
            this.toEmail.Name = "toEmail";
            this.toEmail.Size = new System.Drawing.Size(182, 20);
            this.toEmail.TabIndex = 12;
            this.toEmail.Text = "happytechtesting@gmail.com";
            // 
            // smtpServer
            // 
            this.smtpServer.Location = new System.Drawing.Point(190, 193);
            this.smtpServer.Name = "smtpServer";
            this.smtpServer.Size = new System.Drawing.Size(182, 20);
            this.smtpServer.TabIndex = 13;
            this.smtpServer.Text = "smtp.gmail.com";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(190, 219);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(182, 20);
            this.userName.TabIndex = 14;
            this.userName.Text = "happytechtesting@gmail.com";
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(190, 245);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(182, 20);
            this.userPass.TabIndex = 15;
            // 
            // Backlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.smtpServer);
            this.Controls.Add(this.toEmail);
            this.Controls.Add(this.fromEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.showFilesBtn);
            this.Controls.Add(this.lstFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Backlog";
            this.Text = "Backlog";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button showFilesBtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fromEmail;
        private System.Windows.Forms.TextBox toEmail;
        private System.Windows.Forms.TextBox smtpServer;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userPass;
    }
}