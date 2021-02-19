namespace formsTest
{
    partial class createTemplate
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
            this.generateTemplate = new System.Windows.Forms.Button();
            this.templateTitle = new System.Windows.Forms.TextBox();
            this.templateText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatabase2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase2)).BeginInit();
            this.SuspendLayout();
            // 
            // generateTemplate
            // 
            this.generateTemplate.Location = new System.Drawing.Point(168, 202);
            this.generateTemplate.Name = "generateTemplate";
            this.generateTemplate.Size = new System.Drawing.Size(160, 79);
            this.generateTemplate.TabIndex = 0;
            this.generateTemplate.Text = "Generate Template";
            this.generateTemplate.UseVisualStyleBackColor = true;
            this.generateTemplate.Click += new System.EventHandler(this.generateTemplate_Click);
            // 
            // templateTitle
            // 
            this.templateTitle.Location = new System.Drawing.Point(168, 78);
            this.templateTitle.Name = "templateTitle";
            this.templateTitle.Size = new System.Drawing.Size(100, 20);
            this.templateTitle.TabIndex = 1;
            // 
            // templateText
            // 
            this.templateText.Location = new System.Drawing.Point(168, 123);
            this.templateText.Multiline = true;
            this.templateText.Name = "templateText";
            this.templateText.Size = new System.Drawing.Size(319, 73);
            this.templateText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text";
            // 
            // dgvDatabase2
            // 
            this.dgvDatabase2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase2.Location = new System.Drawing.Point(529, 46);
            this.dgvDatabase2.Name = "dgvDatabase2";
            this.dgvDatabase2.Size = new System.Drawing.Size(240, 150);
            this.dgvDatabase2.TabIndex = 6;
            // 
            // createTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatabase2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.templateText);
            this.Controls.Add(this.templateTitle);
            this.Controls.Add(this.generateTemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createTemplate";
            this.Text = "createTemplate";
            this.Load += new System.EventHandler(this.createTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateTemplate;
        private System.Windows.Forms.TextBox templateTitle;
        private System.Windows.Forms.TextBox templateText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatabase2;
    }
}