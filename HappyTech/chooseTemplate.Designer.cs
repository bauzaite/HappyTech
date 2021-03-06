﻿
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
            this.applicantEmail = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listTemplates = new System.Windows.Forms.ListBox();
            this.templatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.happyTechDBDataSet2 = new HappyTech.HappyTechDBDataSet2();
            this.templatesTableAdapter = new HappyTech.HappyTechDBDataSet2TableAdapters.templatesTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.applicantName = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.applicantStage = new System.Windows.Forms.TextBox();
            this.applicantSuccessful = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panelCreateTemplateTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDBDataSet2)).BeginInit();
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
            // applicantEmail
            // 
            this.applicantEmail.Location = new System.Drawing.Point(29, 248);
            this.applicantEmail.Name = "applicantEmail";
            this.applicantEmail.Size = new System.Drawing.Size(245, 20);
            this.applicantEmail.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Applicant Email:";
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
            // templatesBindingSource
            // 
            this.templatesBindingSource.DataMember = "templates";
            this.templatesBindingSource.DataSource = this.happyTechDBDataSet2;
            // 
            // happyTechDBDataSet2
            // 
            this.happyTechDBDataSet2.DataSetName = "HappyTechDBDataSet2";
            this.happyTechDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // templatesTableAdapter
            // 
            this.templatesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "Applicant Name:";
            // 
            // applicantName
            // 
            this.applicantName.Location = new System.Drawing.Point(29, 175);
            this.applicantName.Name = "applicantName";
            this.applicantName.Size = new System.Drawing.Size(245, 20);
            this.applicantName.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(29, 286);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(245, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.Text = "Applicant Stage:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(29, 357);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(245, 20);
            this.textBox6.TabIndex = 18;
            this.textBox6.Text = "Applicant Successful:";
            // 
            // applicantStage
            // 
            this.applicantStage.Location = new System.Drawing.Point(29, 312);
            this.applicantStage.Name = "applicantStage";
            this.applicantStage.Size = new System.Drawing.Size(245, 20);
            this.applicantStage.TabIndex = 19;
            // 
            // applicantSuccessful
            // 
            this.applicantSuccessful.Location = new System.Drawing.Point(29, 383);
            this.applicantSuccessful.Name = "applicantSuccessful";
            this.applicantSuccessful.Size = new System.Drawing.Size(245, 20);
            this.applicantSuccessful.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Next Step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.nextStep_Click);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(29, 121);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(120, 13);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "Applicant Information:";
            // 
            // chooseTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.applicantSuccessful);
            this.Controls.Add(this.applicantStage);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.applicantName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.listTemplates);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.applicantEmail);
            this.Controls.Add(this.textBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDBDataSet2)).EndInit();
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
        private System.Windows.Forms.TextBox applicantEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listTemplates;
        private HappyTechDBDataSet2 happyTechDBDataSet2;
        private System.Windows.Forms.BindingSource templatesBindingSource;
        private HappyTechDBDataSet2TableAdapters.templatesTableAdapter templatesTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox applicantName;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox applicantStage;
        private System.Windows.Forms.TextBox applicantSuccessful;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
    }
}