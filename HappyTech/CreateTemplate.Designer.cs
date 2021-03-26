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
            this.components = new System.ComponentModel.Container();
            this.templateTitle = new System.Windows.Forms.TextBox();
            this.panelCreateTemplateTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.templateText = new System.Windows.Forms.TextBox();
            this.submitTemplateBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.peviewTemplateTitle = new System.Windows.Forms.TextBox();
            this.previewTemplateText = new System.Windows.Forms.ListBox();
            this.templateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBase_Data = new HappyTech.DataBase_Data();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templateTableAdapter = new HappyTech.DataBase_DataTableAdapters.TemplateTableAdapter();
            this.panelCreateTemplateTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // templateTitle
            // 
            this.templateTitle.Location = new System.Drawing.Point(47, 211);
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
            // templateText
            // 
            this.templateText.Location = new System.Drawing.Point(47, 277);
            this.templateText.Multiline = true;
            this.templateText.Name = "templateText";
            this.templateText.Size = new System.Drawing.Size(543, 25);
            this.templateText.TabIndex = 3;
            // 
            // submitTemplateBTN
            // 
            this.submitTemplateBTN.Location = new System.Drawing.Point(643, 268);
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
            this.label2.Location = new System.Drawing.Point(44, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Template Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Template Text:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(47, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(762, 21);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "To create a new template: Give it a title, a category, choose weather it is assoc" +
    "iated to a successful applicant and finally save an automated sentance(s).";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Preview Saved Template:";
            // 
            // peviewTemplateTitle
            // 
            this.peviewTemplateTitle.Location = new System.Drawing.Point(47, 386);
            this.peviewTemplateTitle.Name = "peviewTemplateTitle";
            this.peviewTemplateTitle.Size = new System.Drawing.Size(225, 20);
            this.peviewTemplateTitle.TabIndex = 17;
            // 
            // previewTemplateText
            // 
            this.previewTemplateText.FormattingEnabled = true;
            this.previewTemplateText.Location = new System.Drawing.Point(47, 421);
            this.previewTemplateText.Name = "previewTemplateText";
            this.previewTemplateText.Size = new System.Drawing.Size(466, 95);
            this.previewTemplateText.TabIndex = 18;
            // 
            // templateBindingSource1
            // 
            this.templateBindingSource1.DataMember = "Template";
            this.templateBindingSource1.DataSource = this.dataBaseDataBindingSource;
            // 
            // dataBaseDataBindingSource
            // 
            this.dataBaseDataBindingSource.DataSource = this.dataBase_Data;
            this.dataBaseDataBindingSource.Position = 0;
            // 
            // dataBase_Data
            // 
            this.dataBase_Data.DataSetName = "DataBase_Data";
            this.dataBase_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(535, 421);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(294, 46);
            this.richTextBox2.TabIndex = 19;
            this.richTextBox2.Text = "Tip: To add another sentance, simply fill \'Template Text\' section again.";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(535, 473);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(294, 46);
            this.richTextBox3.TabIndex = 20;
            this.richTextBox3.Text = "Tip: To delete or edit this template, navigate to \'Edit Template\' page found on t" +
    "he side bar on the left.";
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataMember = "Template";
            this.templateBindingSource.DataSource = typeof(HappyTech.HappyTechDBDataSet);
            // 
            // templateTableAdapter
            // 
            this.templateTableAdapter.ClearBeforeFill = true;
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 561);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.previewTemplateText);
            this.Controls.Add(this.peviewTemplateTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitTemplateBTN);
            this.Controls.Add(this.templateText);
            this.Controls.Add(this.panelCreateTemplateTitle);
            this.Controls.Add(this.templateTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTemplate";
            this.Text = "CreateTemplate";
            this.panelCreateTemplateTitle.ResumeLayout(false);
            this.panelCreateTemplateTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelCreateTemplateTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitTemplateBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox peviewTemplateTitle;
        private System.Windows.Forms.ListBox previewTemplateText;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.BindingSource templateBindingSource;
        private System.Windows.Forms.BindingSource dataBaseDataBindingSource;
        private DataBase_Data dataBase_Data;
        private System.Windows.Forms.BindingSource templateBindingSource1;
        private DataBase_DataTableAdapters.TemplateTableAdapter templateTableAdapter;
        public System.Windows.Forms.TextBox templateText;
        public System.Windows.Forms.TextBox templateTitle;
    }
}