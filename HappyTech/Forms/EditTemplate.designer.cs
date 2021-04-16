
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
            this.label2 = new System.Windows.Forms.Label();
            this.templateTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.templateText = new System.Windows.Forms.TextBox();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Template Title:";
            // 
            // templateTitle
            // 
            this.templateTitle.Location = new System.Drawing.Point(47, 171);
            this.templateTitle.Name = "templateTitle";
            this.templateTitle.Size = new System.Drawing.Size(225, 20);
            this.templateTitle.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Template Text:";
            // 
            // templateText
            // 
            this.templateText.Location = new System.Drawing.Point(47, 299);
            this.templateText.Multiline = true;
            this.templateText.Name = "templateText";
            this.templateText.Size = new System.Drawing.Size(513, 25);
            this.templateText.TabIndex = 13;
            // 
            // EditTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 667);
            this.Controls.Add(this.templateText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.templateTitle);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox templateTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox templateText;
    }
}