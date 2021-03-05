
namespace HappyTech
{
    partial class Home
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
            this.label3 = new System.Windows.Forms.Label();
            this.applicantChoice = new System.Windows.Forms.ComboBox();
            this.applicantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicant = new HappyTech.applicant();
            this.applicantTableAdapter = new HappyTech.applicantTableAdapters.ApplicantTableAdapter();
            this.reviewButton = new System.Windows.Forms.Button();
            this.panelCreateTemplateTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicant)).BeginInit();
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
            this.panelCreateTemplateTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(360, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please select below an applicant to respond to:";
            // 
            // applicantChoice
            // 
            this.applicantChoice.DataSource = this.applicantBindingSource1;
            this.applicantChoice.DisplayMember = "Applicant_Id";
            this.applicantChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.applicantChoice.FormattingEnabled = true;
            this.applicantChoice.Location = new System.Drawing.Point(242, 200);
            this.applicantChoice.Name = "applicantChoice";
            this.applicantChoice.Size = new System.Drawing.Size(325, 21);
            this.applicantChoice.TabIndex = 11;
            // 
            // applicantBindingSource1
            // 
            this.applicantBindingSource1.DataMember = "Applicant";
            this.applicantBindingSource1.DataSource = this.applicantBindingSource;
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataSource = this.applicant;
            this.applicantBindingSource.Position = 0;
            // 
            // applicant
            // 
            this.applicant.DataSetName = "applicant";
            this.applicant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantTableAdapter
            // 
            this.applicantTableAdapter.ClearBeforeFill = true;
            // 
            // reviewButton
            // 
            this.reviewButton.Location = new System.Drawing.Point(492, 239);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(75, 23);
            this.reviewButton.TabIndex = 12;
            this.reviewButton.Text = "Respond";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.applicantChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelCreateTemplateTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelCreateTemplateTitle.ResumeLayout(false);
            this.panelCreateTemplateTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateTemplateTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private applicant applicant;
        private System.Windows.Forms.BindingSource applicantBindingSource1;
        private applicantTableAdapters.ApplicantTableAdapter applicantTableAdapter;
        private System.Windows.Forms.Button reviewButton;
        public System.Windows.Forms.ComboBox applicantChoice;
    }
}