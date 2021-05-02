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
            panelMain = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelLeftNav = new System.Windows.Forms.Panel();
            this.btnBacklog = new System.Windows.Forms.Button();
            this.showEditTemplate = new System.Windows.Forms.Button();
            this.showCreateTemplate = new System.Windows.Forms.Button();
            this.showHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            panelMain.SuspendLayout();
            this.panelLeftNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.White;
            panelMain.Controls.Add(this.panelTitle);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(220, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(855, 667);
            panelMain.TabIndex = 9;
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
            this.panelLeftNav.Controls.Add(this.btnBacklog);
            this.panelLeftNav.Controls.Add(this.showEditTemplate);
            this.panelLeftNav.Controls.Add(this.showCreateTemplate);
            this.panelLeftNav.Controls.Add(this.showHome);
            this.panelLeftNav.Controls.Add(this.panelLogo);
            this.panelLeftNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNav.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNav.Name = "panelLeftNav";
            this.panelLeftNav.Size = new System.Drawing.Size(220, 667);
            this.panelLeftNav.TabIndex = 8;
            // 
            // btnBacklog
            // 
            this.btnBacklog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBacklog.FlatAppearance.BorderSize = 0;
            this.btnBacklog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacklog.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBacklog.Location = new System.Drawing.Point(0, 260);
            this.btnBacklog.Name = "btnBacklog";
            this.btnBacklog.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBacklog.Size = new System.Drawing.Size(220, 60);
            this.btnBacklog.TabIndex = 10;
            this.btnBacklog.Text = "Backlog";
            this.btnBacklog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBacklog.UseVisualStyleBackColor = true;
            this.btnBacklog.Click += new System.EventHandler(this.button1_Click);
            // 
            // showEditTemplate
            // 
            this.showEditTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.showEditTemplate.FlatAppearance.BorderSize = 0;
            this.showEditTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showEditTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEditTemplate.ForeColor = System.Drawing.Color.Gainsboro;
            this.showEditTemplate.Location = new System.Drawing.Point(0, 200);
            this.showEditTemplate.Name = "showEditTemplate";
            this.showEditTemplate.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.showEditTemplate.Size = new System.Drawing.Size(220, 60);
            this.showEditTemplate.TabIndex = 9;
            this.showEditTemplate.Text = "Edit Template";
            this.showEditTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showEditTemplate.UseVisualStyleBackColor = true;
            this.showEditTemplate.Click += new System.EventHandler(this.showEditTemplate_Click);
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
            this.Controls.Add(panelMain);
            this.Controls.Add(this.panelLeftNav);
            this.Name = "Border";
            this.Text = "Main";
            panelMain.ResumeLayout(false);
            this.panelLeftNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftNav;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button showCreateTemplate;
        private System.Windows.Forms.Button showHome;
        private System.Windows.Forms.Button showEditTemplate;
        private System.Windows.Forms.Button btnBacklog;
        public static System.Windows.Forms.Panel panelMain;
    }
}