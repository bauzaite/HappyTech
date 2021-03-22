﻿namespace HappyTech
{
    partial class CreateTemplate
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
            this.templateTitle = new System.Windows.Forms.TextBox();
            this.panelCreateTemplateTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.templateCategorySelection = new System.Windows.Forms.ComboBox();
            this.templateText1 = new System.Windows.Forms.TextBox();
            this.submitTemplateBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioBTNTrue = new System.Windows.Forms.RadioButton();
            this.radioBTNFalse = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panelCreateTemplateTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // templateTitle
            // 
            this.templateTitle.Location = new System.Drawing.Point(47, 201);
            this.templateTitle.Name = "templateTitle";
            this.templateTitle.Size = new System.Drawing.Size(225, 20);
            this.templateTitle.TabIndex = 0;
            // 
            // panelCreateTemplateTitle
            // 
            this.panelCreateTemplateTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panelCreateTemplateTitle.Controls.Add(this.label1);
            this.panelCreateTemplateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreateTemplateTitle.Location = new System.Drawing.Point(0, 0);
            this.panelCreateTemplateTitle.Name = "panelCreateTemplateTitle";
            this.panelCreateTemplateTitle.Size = new System.Drawing.Size(855, 80);
            this.panelCreateTemplateTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(331, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a New Template";
            // 
            // templateCategorySelection
            // 
            this.templateCategorySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templateCategorySelection.FormattingEnabled = true;
            this.templateCategorySelection.Items.AddRange(new object[] {
            "CV Presentation",
            "Interview Skills",
            "Technical Ability"});
            this.templateCategorySelection.Location = new System.Drawing.Point(47, 262);
            this.templateCategorySelection.Name = "templateCategorySelection";
            this.templateCategorySelection.Size = new System.Drawing.Size(121, 21);
            this.templateCategorySelection.TabIndex = 5;
            // 
            // templateText1
            // 
            this.templateText1.Location = new System.Drawing.Point(47, 329);
            this.templateText1.Multiline = true;
            this.templateText1.Name = "templateText1";
            this.templateText1.Size = new System.Drawing.Size(543, 25);
            this.templateText1.TabIndex = 3;
            // 
            // submitTemplateBTN
            // 
            this.submitTemplateBTN.Location = new System.Drawing.Point(643, 320);
            this.submitTemplateBTN.Name = "submitTemplateBTN";
            this.submitTemplateBTN.Size = new System.Drawing.Size(115, 36);
            this.submitTemplateBTN.TabIndex = 6;
            this.submitTemplateBTN.Text = "Save";
            this.submitTemplateBTN.UseVisualStyleBackColor = true;
            this.submitTemplateBTN.Click += new System.EventHandler(this.submitTemplateBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Template Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Template Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Template Text:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(47, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(762, 34);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "To create a new template: Give it a title, a category, choose weather it is assoc" +
    "iated to a successful applicant and finally save an automated sentance(s).";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Preview Saved Template:";
            // 
            // radioBTNTrue
            // 
            this.radioBTNTrue.AutoSize = true;
            this.radioBTNTrue.Location = new System.Drawing.Point(275, 261);
            this.radioBTNTrue.Name = "radioBTNTrue";
            this.radioBTNTrue.Size = new System.Drawing.Size(14, 13);
            this.radioBTNTrue.TabIndex = 4;
            this.radioBTNTrue.TabStop = true;
            this.radioBTNTrue.UseVisualStyleBackColor = true;
            // 
            // radioBTNFalse
            // 
            this.radioBTNFalse.AutoSize = true;
            this.radioBTNFalse.Location = new System.Drawing.Point(364, 261);
            this.radioBTNFalse.Name = "radioBTNFalse";
            this.radioBTNFalse.Size = new System.Drawing.Size(14, 13);
            this.radioBTNFalse.TabIndex = 5;
            this.radioBTNFalse.TabStop = true;
            this.radioBTNFalse.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Successful / Unsuccessful:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 472);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 498);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(288, 472);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(288, 498);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 20);
            this.textBox4.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(47, 524);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(466, 95);
            this.listBox1.TabIndex = 18;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(536, 472);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(294, 46);
            this.richTextBox2.TabIndex = 19;
            this.richTextBox2.Text = "Tip: To add another sentance, simply fill \'Template Text\' section again.";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(536, 535);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(294, 46);
            this.richTextBox3.TabIndex = 20;
            this.richTextBox3.Text = "Tip: To delete or edit this template, navigate to \'Edit Template\' page found on t" +
    "he side bar on the left.";
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 667);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitTemplateBTN);
            this.Controls.Add(this.radioBTNFalse);
            this.Controls.Add(this.radioBTNTrue);
            this.Controls.Add(this.templateText1);
            this.Controls.Add(this.templateCategorySelection);
            this.Controls.Add(this.panelCreateTemplateTitle);
            this.Controls.Add(this.templateTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTemplate";
            this.Text = "CreateTemplate";
            this.panelCreateTemplateTitle.ResumeLayout(false);
            this.panelCreateTemplateTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox templateTitle;
        private System.Windows.Forms.Panel panelCreateTemplateTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox templateCategorySelection;
        private System.Windows.Forms.TextBox templateText1;
        private System.Windows.Forms.Button submitTemplateBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioBTNTrue;
        private System.Windows.Forms.RadioButton radioBTNFalse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}