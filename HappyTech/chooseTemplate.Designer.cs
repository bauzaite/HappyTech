
namespace HappyTech
{
    partial class chooseTemplate
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
            this.panelCreateTemplateTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.applicantInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.happyTechDBDataSet1 = new HappyTech.HappyTechDBDataSet1();
            this.applicant_InformationTableAdapter = new HappyTech.HappyTechDBDataSet1TableAdapters.Applicant_InformationTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.applicantName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listTemplates = new System.Windows.Forms.ListBox();
            this.happyTechDBDataSet2 = new HappyTech.HappyTechDBDataSet2();
            this.templatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templatesTableAdapter = new HappyTech.HappyTechDBDataSet2TableAdapters.templatesTableAdapter();
            this.panelCreateTemplateTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCreateTemplateTitle
            // 
            this.panelCreateTemplateTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.panelCreateTemplateTitle.Controls.Add(this.label1);
            this.panelCreateTemplateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreateTemplateTitle.Location = new System.Drawing.Point(0, 0);
            this.panelCreateTemplateTitle.Name = "panelCreateTemplateTitle";
            this.panelCreateTemplateTitle.Size = new System.Drawing.Size(800, 80);
            this.panelCreateTemplateTitle.TabIndex = 3;
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
            // applicantInformationBindingSource
            // 
            this.applicantInformationBindingSource.DataMember = "Applicant_Information";
            this.applicantInformationBindingSource.DataSource = this.happyTechDBDataSet1;
            // 
            // happyTechDBDataSet1
            // 
            this.happyTechDBDataSet1.DataSetName = "HappyTechDBDataSet1";
            this.happyTechDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicant_InformationTableAdapter
            // 
            this.applicant_InformationTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(263, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 13);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Step 1: Choose template for the applicant";
            // 
            // applicantName
            // 
            this.applicantName.Location = new System.Drawing.Point(43, 161);
            this.applicantName.Name = "applicantName";
            this.applicantName.Size = new System.Drawing.Size(245, 20);
            this.applicantName.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "This below is mean tto hold info about applicant:";
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.DataSource = this.applicantInformationBindingSource;
            this.listBox1.DisplayMember = "Applicant_fName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 17);
            this.listBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Displays all applicants:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(421, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "Select Template";
            // 
            // listTemplates
            // 
            this.listTemplates.DataSource = this.templatesBindingSource;
            this.listTemplates.DisplayMember = "templateTitle";
            this.listTemplates.FormattingEnabled = true;
            this.listTemplates.Location = new System.Drawing.Point(421, 161);
            this.listTemplates.Name = "listTemplates";
            this.listTemplates.Size = new System.Drawing.Size(221, 134);
            this.listTemplates.TabIndex = 14;
            // 
            // happyTechDBDataSet2
            // 
            this.happyTechDBDataSet2.DataSetName = "HappyTechDBDataSet2";
            this.happyTechDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // templatesBindingSource
            // 
            this.templatesBindingSource.DataMember = "templates";
            this.templatesBindingSource.DataSource = this.happyTechDBDataSet2;
            // 
            // templatesTableAdapter
            // 
            this.templatesTableAdapter.ClearBeforeFill = true;
            // 
            // chooseTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listTemplates);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.applicantName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panelCreateTemplateTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chooseTemplate";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.chooseTemplate_Load);
            this.panelCreateTemplateTitle.ResumeLayout(false);
            this.panelCreateTemplateTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateTemplateTitle;
        private System.Windows.Forms.Label label1;
        private HappyTechDBDataSet1 happyTechDBDataSet1;
        private System.Windows.Forms.BindingSource applicantInformationBindingSource;
        private HappyTechDBDataSet1TableAdapters.Applicant_InformationTableAdapter applicant_InformationTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox applicantName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listTemplates;
        private HappyTechDBDataSet2 happyTechDBDataSet2;
        private System.Windows.Forms.BindingSource templatesBindingSource;
        private HappyTechDBDataSet2TableAdapters.templatesTableAdapter templatesTableAdapter;
    }
}