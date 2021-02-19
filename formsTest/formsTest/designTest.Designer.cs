namespace formsTest
{
    partial class designTest
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
            this.navPanel = new System.Windows.Forms.Panel();
            this.createTemplate = new System.Windows.Forms.Button();
            this.Form1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginForm = new System.Windows.Forms.Button();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.Teal;
            this.navPanel.Controls.Add(this.LoginForm);
            this.navPanel.Controls.Add(this.createTemplate);
            this.navPanel.Controls.Add(this.Form1);
            this.navPanel.Controls.Add(this.panel1);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(220, 622);
            this.navPanel.TabIndex = 0;
            // 
            // createTemplate
            // 
            this.createTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.createTemplate.FlatAppearance.BorderSize = 0;
            this.createTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTemplate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTemplate.ForeColor = System.Drawing.SystemColors.Control;
            this.createTemplate.Location = new System.Drawing.Point(0, 219);
            this.createTemplate.Name = "createTemplate";
            this.createTemplate.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.createTemplate.Size = new System.Drawing.Size(220, 62);
            this.createTemplate.TabIndex = 2;
            this.createTemplate.Text = "Create Template";
            this.createTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createTemplate.UseVisualStyleBackColor = true;
            this.createTemplate.Click += new System.EventHandler(this.createTemplate_Click);
            // 
            // Form1
            // 
            this.Form1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Form1.FlatAppearance.BorderSize = 0;
            this.Form1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1.ForeColor = System.Drawing.SystemColors.Control;
            this.Form1.Location = new System.Drawing.Point(0, 157);
            this.Form1.Name = "Form1";
            this.Form1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Form1.Size = new System.Drawing.Size(220, 62);
            this.Form1.TabIndex = 1;
            this.Form1.Text = "Form1";
            this.Form1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Form1.UseVisualStyleBackColor = true;
            this.Form1.Click += new System.EventHandler(this.Form1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 157);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 622);
            this.panel2.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.LoginForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginForm.FlatAppearance.BorderSize = 0;
            this.LoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginForm.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginForm.Location = new System.Drawing.Point(0, 281);
            this.LoginForm.Name = "LoginForm";
            this.LoginForm.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LoginForm.Size = new System.Drawing.Size(220, 62);
            this.LoginForm.TabIndex = 3;
            this.LoginForm.Text = "Login Test";
            this.LoginForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginForm.UseVisualStyleBackColor = true;
            // 
            // designTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.navPanel);
            this.Name = "designTest";
            this.Text = "designTest";
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button createTemplate;
        private System.Windows.Forms.Button Form1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LoginForm;
    }
}