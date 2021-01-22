namespace formsTest
{
    partial class Form1
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
            this.GetCon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GetData = new System.Windows.Forms.Button();
            this.dgvDatabase1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetCon
            // 
            this.GetCon.Location = new System.Drawing.Point(67, 74);
            this.GetCon.Name = "GetCon";
            this.GetCon.Size = new System.Drawing.Size(156, 114);
            this.GetCon.TabIndex = 0;
            this.GetCon.Text = "Click Here";
            this.GetCon.UseVisualStyleBackColor = true;
            this.GetCon.Click += new System.EventHandler(this.GetCon_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(229, 45);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(75, 23);
            this.GetData.TabIndex = 3;
            this.GetData.Text = "Get data";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // dgvDatabase1
            // 
            this.dgvDatabase1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase1.Location = new System.Drawing.Point(305, 146);
            this.dgvDatabase1.Name = "dgvDatabase1";
            this.dgvDatabase1.Size = new System.Drawing.Size(240, 150);
            this.dgvDatabase1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatabase1);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GetCon);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetCon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.DataGridView dgvDatabase1;
    }
}

