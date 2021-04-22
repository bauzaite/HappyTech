
namespace HappyTech.Forms
{
    partial class EditTemplate
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
            this.createTemplateTitle = new System.Windows.Forms.Label();
            this.previewTemplateText = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.templateText = new System.Windows.Forms.TextBox();
            this.templateTitle = new System.Windows.Forms.TextBox();
            this.templateChoice = new System.Windows.Forms.ListBox();
            this.updateText = new System.Windows.Forms.Button();
            this.deleteText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCreateTemplateTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateTemplateTitle
            // 
            this.panelCreateTemplateTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panelCreateTemplateTitle.Controls.Add(this.createTemplateTitle);
            this.panelCreateTemplateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreateTemplateTitle.Location = new System.Drawing.Point(0, 0);
            this.panelCreateTemplateTitle.Name = "panelCreateTemplateTitle";
            this.panelCreateTemplateTitle.Size = new System.Drawing.Size(855, 80);
            this.panelCreateTemplateTitle.TabIndex = 2;
            // 
            // createTemplateTitle
            // 
            this.createTemplateTitle.AutoSize = true;
            this.createTemplateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTemplateTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.createTemplateTitle.Location = new System.Drawing.Point(331, 30);
            this.createTemplateTitle.Name = "createTemplateTitle";
            this.createTemplateTitle.Size = new System.Drawing.Size(144, 25);
            this.createTemplateTitle.TabIndex = 0;
            this.createTemplateTitle.Text = "Edit Template";
            // 
            // previewTemplateText
            // 
            this.previewTemplateText.FormattingEnabled = true;
            this.previewTemplateText.Location = new System.Drawing.Point(46, 268);
            this.previewTemplateText.Name = "previewTemplateText";
            this.previewTemplateText.Size = new System.Drawing.Size(466, 95);
            this.previewTemplateText.TabIndex = 25;
            this.previewTemplateText.SelectedIndexChanged += new System.EventHandler(this.previewTemplateText_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Preview Saved Template:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Template Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Template Title:";
            // 
            // templateText
            // 
            this.templateText.Location = new System.Drawing.Point(46, 405);
            this.templateText.Multiline = true;
            this.templateText.Name = "templateText";
            this.templateText.Size = new System.Drawing.Size(543, 25);
            this.templateText.TabIndex = 20;
            // 
            // templateTitle
            // 
            this.templateTitle.Location = new System.Drawing.Point(47, 211);
            this.templateTitle.Name = "templateTitle";
            this.templateTitle.Size = new System.Drawing.Size(225, 20);
            this.templateTitle.TabIndex = 19;
            // 
            // templateChoice
            // 
            this.templateChoice.FormattingEnabled = true;
            this.templateChoice.Location = new System.Drawing.Point(622, 131);
            this.templateChoice.Name = "templateChoice";
            this.templateChoice.Size = new System.Drawing.Size(221, 134);
            this.templateChoice.TabIndex = 27;
            this.templateChoice.SelectedIndexChanged += new System.EventHandler(this.templateChoice_SelectedIndexChanged);
            // 
            // updateText
            // 
            this.updateText.Location = new System.Drawing.Point(46, 436);
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(75, 23);
            this.updateText.TabIndex = 28;
            this.updateText.Text = "Update";
            this.updateText.UseVisualStyleBackColor = true;
            this.updateText.Click += new System.EventHandler(this.updateText_Click);
            // 
            // deleteText
            // 
            this.deleteText.Location = new System.Drawing.Point(127, 436);
            this.deleteText.Name = "deleteText";
            this.deleteText.Size = new System.Drawing.Size(75, 23);
            this.deleteText.TabIndex = 29;
            this.deleteText.Text = "Delete";
            this.deleteText.UseVisualStyleBackColor = true;
            this.deleteText.Click += new System.EventHandler(this.deleteText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Template:";
            // 
            // EditTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteText);
            this.Controls.Add(this.updateText);
            this.Controls.Add(this.templateChoice);
            this.Controls.Add(this.previewTemplateText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.templateText);
            this.Controls.Add(this.templateTitle);
            this.Controls.Add(this.panelCreateTemplateTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTemplate";
            this.Text = "EditTemplate";
            this.panelCreateTemplateTitle.ResumeLayout(false);
            this.panelCreateTemplateTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateTemplateTitle;
        private System.Windows.Forms.Label createTemplateTitle;
        public System.Windows.Forms.ListBox previewTemplateText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox templateText;
        public System.Windows.Forms.TextBox templateTitle;
        public System.Windows.Forms.ListBox templateChoice;
        private System.Windows.Forms.Button updateText;
        private System.Windows.Forms.Button deleteText;
        private System.Windows.Forms.Label label1;
    }
}