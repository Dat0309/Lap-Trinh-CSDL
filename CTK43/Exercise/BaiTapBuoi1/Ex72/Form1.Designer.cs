
namespace Ex72
{
    partial class DemoTabPage
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSVID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSV = new System.Windows.Forms.ComboBox();
            this.txtSVName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGVID = new System.Windows.Forms.TextBox();
            this.txtGVName = new System.Windows.Forms.TextBox();
            this.cbbGV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGV = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 210);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSV);
            this.tabPage3.Controls.Add(this.txtSVID);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cbbSV);
            this.tabPage3.Controls.Add(this.txtSVName);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(316, 184);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Sinh Vien";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSVID
            // 
            this.txtSVID.Location = new System.Drawing.Point(61, 93);
            this.txtSVID.Name = "txtSVID";
            this.txtSVID.Size = new System.Drawing.Size(121, 20);
            this.txtSVID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khoa";
            // 
            // cbbSV
            // 
            this.cbbSV.FormattingEnabled = true;
            this.cbbSV.Items.AddRange(new object[] {
            "International Technology",
            "Matherithtic",
            "Biology",
            "History"});
            this.cbbSV.Location = new System.Drawing.Point(61, 16);
            this.cbbSV.Name = "cbbSV";
            this.cbbSV.Size = new System.Drawing.Size(121, 21);
            this.cbbSV.TabIndex = 2;
            // 
            // txtSVName
            // 
            this.txtSVName.Location = new System.Drawing.Point(61, 54);
            this.txtSVName.Name = "txtSVName";
            this.txtSVName.Size = new System.Drawing.Size(181, 20);
            this.txtSVName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGV);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbbGV);
            this.tabPage1.Controls.Add(this.txtGVName);
            this.tabPage1.Controls.Add(this.txtGVID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(316, 184);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Giao vien";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(316, 184);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Mon hoc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSV
            // 
            this.btnSV.Location = new System.Drawing.Point(61, 141);
            this.btnSV.Name = "btnSV";
            this.btnSV.Size = new System.Drawing.Size(75, 23);
            this.btnSV.TabIndex = 6;
            this.btnSV.Text = "Submit";
            this.btnSV.UseVisualStyleBackColor = true;
            this.btnSV.Click += new System.EventHandler(this.btnSV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "MSGV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "HoTen";
            // 
            // txtGVID
            // 
            this.txtGVID.Location = new System.Drawing.Point(98, 23);
            this.txtGVID.Name = "txtGVID";
            this.txtGVID.Size = new System.Drawing.Size(109, 20);
            this.txtGVID.TabIndex = 2;
            // 
            // txtGVName
            // 
            this.txtGVName.Location = new System.Drawing.Point(98, 57);
            this.txtGVName.Name = "txtGVName";
            this.txtGVName.Size = new System.Drawing.Size(156, 20);
            this.txtGVName.TabIndex = 3;
            // 
            // cbbGV
            // 
            this.cbbGV.FormattingEnabled = true;
            this.cbbGV.Location = new System.Drawing.Point(98, 103);
            this.cbbGV.Name = "cbbGV";
            this.cbbGV.Size = new System.Drawing.Size(121, 21);
            this.cbbGV.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mon hoc";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 160);
            this.listBox1.TabIndex = 0;
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(98, 150);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(75, 23);
            this.btnGV.TabIndex = 6;
            this.btnGV.Text = "Submit";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // DemoTabPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(349, 235);
            this.Controls.Add(this.tabControl1);
            this.Name = "DemoTabPage";
            this.Text = "Demo TabPage";
            this.Load += new System.EventHandler(this.DemoTabPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtSVID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSV;
        private System.Windows.Forms.TextBox txtSVName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSV;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbGV;
        private System.Windows.Forms.TextBox txtGVName;
        private System.Windows.Forms.TextBox txtGVID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

