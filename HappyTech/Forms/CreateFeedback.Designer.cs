
namespace HappyTech
{
    partial class createFeedback
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
            this.panelCreateTemplateTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.generatedSentances = new System.Windows.Forms.CheckedListBox();
            this.email = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.emailInBacklog = new System.Windows.Forms.Button();
            this.applicantSuccessful = new System.Windows.Forms.TextBox();
            this.applicantStage = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.applicantName = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.applicantEmail = new System.Windows.Forms.TextBox();
            this.panelCreateTemplateTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateTemplateTitle
            // 
            this.panelCreateTemplateTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panelCreateTemplateTitle.Controls.Add(this.label1);
            this.panelCreateTemplateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreateTemplateTitle.Location = new System.Drawing.Point(0, 0);
            this.panelCreateTemplateTitle.Name = "panelCreateTemplateTitle";
            this.panelCreateTemplateTitle.Size = new System.Drawing.Size(854, 80);
            this.panelCreateTemplateTitle.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(236, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create feedback for applicant";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(295, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 13);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Step 2: Create feedback for applicant";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(27, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 13);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Applicant Information:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(269, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 13);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Choose auto generated sentances:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(269, 376);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 13);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Preview and edit email:";
            // 
            // generatedSentances
            // 
            this.generatedSentances.FormattingEnabled = true;
            this.generatedSentances.Location = new System.Drawing.Point(269, 149);
            this.generatedSentances.Name = "generatedSentances";
            this.generatedSentances.Size = new System.Drawing.Size(505, 139);
            this.generatedSentances.TabIndex = 19;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(269, 395);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(505, 129);
            this.email.TabIndex = 21;
            this.email.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add to email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addToEmail_Click);
            // 
            // emailInBacklog
            // 
            this.emailInBacklog.Location = new System.Drawing.Point(672, 530);
            this.emailInBacklog.Name = "emailInBacklog";
            this.emailInBacklog.Size = new System.Drawing.Size(102, 23);
            this.emailInBacklog.TabIndex = 24;
            this.emailInBacklog.Text = "Save to backlog";
            this.emailInBacklog.UseVisualStyleBackColor = true;
            // 
            // applicantSuccessful
            // 
            this.applicantSuccessful.Location = new System.Drawing.Point(27, 395);
            this.applicantSuccessful.Name = "applicantSuccessful";
            this.applicantSuccessful.Size = new System.Drawing.Size(196, 20);
            this.applicantSuccessful.TabIndex = 32;
            // 
            // applicantStage
            // 
            this.applicantStage.Location = new System.Drawing.Point(27, 324);
            this.applicantStage.Name = "applicantStage";
            this.applicantStage.Size = new System.Drawing.Size(196, 20);
            this.applicantStage.TabIndex = 31;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(27, 369);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(196, 20);
            this.textBox6.TabIndex = 30;
            this.textBox6.Text = "Applicant Successful:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 298);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 20);
            this.textBox5.TabIndex = 29;
            this.textBox5.Text = "Applicant Stage:";
            // 
            // applicantName
            // 
            this.applicantName.Location = new System.Drawing.Point(27, 187);
            this.applicantName.Name = "applicantName";
            this.applicantName.Size = new System.Drawing.Size(196, 20);
            this.applicantName.TabIndex = 28;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(27, 161);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(196, 20);
            this.textBox7.TabIndex = 27;
            this.textBox7.Text = "Applicant Name:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(27, 234);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(196, 20);
            this.textBox8.TabIndex = 26;
            this.textBox8.Text = "Applicant Email:";
            // 
            // applicantEmail
            // 
            this.applicantEmail.Location = new System.Drawing.Point(27, 260);
            this.applicantEmail.Name = "applicantEmail";
            this.applicantEmail.Size = new System.Drawing.Size(196, 20);
            this.applicantEmail.TabIndex = 25;
            // 
            // createFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 632);
            this.Controls.Add(this.applicantSuccessful);
            this.Controls.Add(this.applicantStage);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.applicantName);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.applicantEmail);
            this.Controls.Add(this.emailInBacklog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.generatedSentances);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelCreateTemplateTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createFeedback";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "createFeedback";
            this.Load += new System.EventHandler(this.createFeedback_Load);
            this.panelCreateTemplateTitle.ResumeLayout(false);
            this.panelCreateTemplateTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateTemplateTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckedListBox generatedSentances;
        private System.Windows.Forms.RichTextBox email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button emailInBacklog;
        private System.Windows.Forms.TextBox applicantSuccessful;
        private System.Windows.Forms.TextBox applicantStage;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox applicantName;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox applicantEmail;
    }
}