namespace HappyTech
{
    partial class Border
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Border));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelLeftNav = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.showManageTemplates = new System.Windows.Forms.Button();
            this.showCreateTemplate = new System.Windows.Forms.Button();
            this.showHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelLeftNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(855, 667);
            this.panelMain.TabIndex = 9;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(855, 80);
            this.panelTitle.TabIndex = 0;
            // 
            // panelLeftNav
            // 
            this.panelLeftNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panelLeftNav.Controls.Add(this.button3);
            this.panelLeftNav.Controls.Add(this.showManageTemplates);
            this.panelLeftNav.Controls.Add(this.showCreateTemplate);
            this.panelLeftNav.Controls.Add(this.showHome);
            this.panelLeftNav.Controls.Add(this.panelLogo);
            this.panelLeftNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNav.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNav.Name = "panelLeftNav";
            this.panelLeftNav.Size = new System.Drawing.Size(220, 667);
            this.panelLeftNav.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(0, 260);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(220, 60);
            this.button3.TabIndex = 8;
            this.button3.Text = "Backlog";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // showManageTemplates
            // 
            this.showManageTemplates.Dock = System.Windows.Forms.DockStyle.Top;
            this.showManageTemplates.FlatAppearance.BorderSize = 0;
            this.showManageTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showManageTemplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showManageTemplates.ForeColor = System.Drawing.Color.Gainsboro;
            this.showManageTemplates.Location = new System.Drawing.Point(0, 200);
            this.showManageTemplates.Name = "showManageTemplates";
            this.showManageTemplates.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.showManageTemplates.Size = new System.Drawing.Size(220, 60);
            this.showManageTemplates.TabIndex = 7;
            this.showManageTemplates.Text = "Manage Templates";
            this.showManageTemplates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showManageTemplates.UseVisualStyleBackColor = true;
            this.showManageTemplates.Click += new System.EventHandler(this.showManageTemplates_Click);
            // 
            // showCreateTemplate
            // 
            this.showCreateTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.showCreateTemplate.FlatAppearance.BorderSize = 0;
            this.showCreateTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCreateTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCreateTemplate.ForeColor = System.Drawing.Color.Gainsboro;
            this.showCreateTemplate.Location = new System.Drawing.Point(0, 140);
            this.showCreateTemplate.Name = "showCreateTemplate";
            this.showCreateTemplate.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.showCreateTemplate.Size = new System.Drawing.Size(220, 60);
            this.showCreateTemplate.TabIndex = 6;
            this.showCreateTemplate.Text = "Create Template";
            this.showCreateTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showCreateTemplate.UseVisualStyleBackColor = true;
            this.showCreateTemplate.Click += new System.EventHandler(this.showCreateTemplate_Click);
            // 
            // showHome
            // 
            this.showHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.showHome.FlatAppearance.BorderSize = 0;
            this.showHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.showHome.Location = new System.Drawing.Point(0, 80);
            this.showHome.Name = "showHome";
            this.showHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.showHome.Size = new System.Drawing.Size(220, 60);
            this.showHome.TabIndex = 5;
            this.showHome.Text = "Home";
            this.showHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showHome.UseVisualStyleBackColor = true;
            this.showHome.Click += new System.EventHandler(this.showHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // Border
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 667);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeftNav);
            this.Name = "Border";
            this.Text = "Main";
            this.panelMain.ResumeLayout(false);
            this.panelLeftNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftNav;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button showManageTemplates;
        private System.Windows.Forms.Button showCreateTemplate;
        private System.Windows.Forms.Button showHome;
        public System.Windows.Forms.Panel panelMain;
    }
}