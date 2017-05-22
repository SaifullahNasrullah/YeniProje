namespace DataStructureProject1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dg1995 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dg1996 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dg1997 = new System.Windows.Forms.DataGridView();
            this.btnGeneratDate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1995)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1996)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1997)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 318);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dg1995);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1995";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dg1995
            // 
            this.dg1995.AllowUserToAddRows = false;
            this.dg1995.AllowUserToDeleteRows = false;
            this.dg1995.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1995.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1995.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg1995.Location = new System.Drawing.Point(3, 3);
            this.dg1995.Name = "dg1995";
            this.dg1995.ReadOnly = true;
            this.dg1995.Size = new System.Drawing.Size(959, 286);
            this.dg1995.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg1996);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(965, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1996";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dg1996
            // 
            this.dg1996.AllowUserToAddRows = false;
            this.dg1996.AllowUserToDeleteRows = false;
            this.dg1996.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1996.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1996.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg1996.Location = new System.Drawing.Point(3, 3);
            this.dg1996.Name = "dg1996";
            this.dg1996.ReadOnly = true;
            this.dg1996.Size = new System.Drawing.Size(959, 286);
            this.dg1996.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dg1997);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(965, 292);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "1997";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dg1997
            // 
            this.dg1997.AllowUserToAddRows = false;
            this.dg1997.AllowUserToDeleteRows = false;
            this.dg1997.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg1997.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1997.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg1997.Location = new System.Drawing.Point(3, 3);
            this.dg1997.Name = "dg1997";
            this.dg1997.ReadOnly = true;
            this.dg1997.Size = new System.Drawing.Size(959, 286);
            this.dg1997.TabIndex = 2;
            // 
            // btnGeneratDate
            // 
            this.btnGeneratDate.Location = new System.Drawing.Point(19, 336);
            this.btnGeneratDate.Name = "btnGeneratDate";
            this.btnGeneratDate.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratDate.TabIndex = 2;
            this.btnGeneratDate.Text = "Tarih Üret";
            this.btnGeneratDate.UseVisualStyleBackColor = true;
            this.btnGeneratDate.Click += new System.EventHandler(this.btnGeneratDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 589);
            this.Controls.Add(this.btnGeneratDate);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Ahmet Ercan ÜNAL 05130001212";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1995)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1996)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg1997)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dg1995;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dg1996;
        private System.Windows.Forms.DataGridView dg1997;
        private System.Windows.Forms.Button btnGeneratDate;
    }
}

