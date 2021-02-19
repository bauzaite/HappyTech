namespace HappyTech
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
            this.templateText = new System.Windows.Forms.TextBox();
            this.radioBTNTrue = new System.Windows.Forms.RadioButton();
            this.submitTemplateBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBTNFalse = new System.Windows.Forms.RadioButton();
            this.panelCreateTemplateTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // templateTitle
            // 
            this.templateTitle.Location = new System.Drawing.Point(47, 171);
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
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(331, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Template";
            // 
            // templateCategorySelection
            // 
            this.templateCategorySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templateCategorySelection.FormattingEnabled = true;
            this.templateCategorySelection.Items.AddRange(new object[] {
            "CV Presentation",
            "Interview Skills",
            "Technical Ability"});
            this.templateCategorySelection.Location = new System.Drawing.Point(47, 231);
            this.templateCategorySelection.Name = "templateCategorySelection";
            this.templateCategorySelection.Size = new System.Drawing.Size(121, 21);
            this.templateCategorySelection.TabIndex = 2;
            // 
            // templateText
            // 
            this.templateText.Location = new System.Drawing.Point(47, 289);
            this.templateText.Multiline = true;
            this.templateText.Name = "templateText";
            this.templateText.Size = new System.Drawing.Size(513, 162);
            this.templateText.TabIndex = 3;
            // 
            // radioBTNTrue
            // 
            this.radioBTNTrue.AutoSize = true;
            this.radioBTNTrue.Location = new System.Drawing.Point(79, 489);
            this.radioBTNTrue.Name = "radioBTNTrue";
            this.radioBTNTrue.Size = new System.Drawing.Size(14, 13);
            this.radioBTNTrue.TabIndex = 4;
            this.radioBTNTrue.TabStop = true;
            this.radioBTNTrue.UseVisualStyleBackColor = true;
            // 
            // submitTemplateBTN
            // 
            this.submitTemplateBTN.Location = new System.Drawing.Point(47, 532);
            this.submitTemplateBTN.Name = "submitTemplateBTN";
            this.submitTemplateBTN.Size = new System.Drawing.Size(135, 23);
            this.submitTemplateBTN.TabIndex = 6;
            this.submitTemplateBTN.Text = "Submit Template";
            this.submitTemplateBTN.UseVisualStyleBackColor = true;
            this.submitTemplateBTN.Click += new System.EventHandler(this.submitTemplateBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Template Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Template Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Template Text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Successful / Unsuccessful:";
            // 
            // radioBTNFalse
            // 
            this.radioBTNFalse.AutoSize = true;
            this.radioBTNFalse.Location = new System.Drawing.Point(168, 489);
            this.radioBTNFalse.Name = "radioBTNFalse";
            this.radioBTNFalse.Size = new System.Drawing.Size(14, 13);
            this.radioBTNFalse.TabIndex = 5;
            this.radioBTNFalse.TabStop = true;
            this.radioBTNFalse.UseVisualStyleBackColor = true;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 667);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitTemplateBTN);
            this.Controls.Add(this.radioBTNFalse);
            this.Controls.Add(this.radioBTNTrue);
            this.Controls.Add(this.templateText);
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
        private System.Windows.Forms.TextBox templateText;
        private System.Windows.Forms.RadioButton radioBTNTrue;
        private System.Windows.Forms.Button submitTemplateBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioBTNFalse;
    }
}