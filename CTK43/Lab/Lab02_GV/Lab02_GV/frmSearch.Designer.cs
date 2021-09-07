
namespace Lab02_GV
{
    partial class frmSearch
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
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.rdSDT = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.Location = new System.Drawing.Point(32, 29);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(71, 17);
            this.lbTimKiem.TabIndex = 0;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(147, 29);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(381, 20);
            this.txtKey.TabIndex = 1;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(147, 70);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(84, 17);
            this.rdTen.TabIndex = 2;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Tìm theo tên";
            this.rdTen.UseVisualStyleBackColor = true;
            this.rdTen.CheckedChanged += new System.EventHandler(this.rdTen_CheckedChanged);
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Location = new System.Drawing.Point(280, 70);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(83, 17);
            this.rdMa.TabIndex = 3;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Tìm theo mã";
            this.rdMa.UseVisualStyleBackColor = true;
            this.rdMa.CheckedChanged += new System.EventHandler(this.rdMa_CheckedChanged);
            // 
            // rdSDT
            // 
            this.rdSDT.AutoSize = true;
            this.rdSDT.Location = new System.Drawing.Point(427, 70);
            this.rdSDT.Name = "rdSDT";
            this.rdSDT.Size = new System.Drawing.Size(91, 17);
            this.rdSDT.TabIndex = 4;
            this.rdSDT.TabStop = true;
            this.rdSDT.Text = "Tìm theo SDT";
            this.rdSDT.UseVisualStyleBackColor = true;
            this.rdSDT.CheckedChanged += new System.EventHandler(this.rdSDT_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 166);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdSDT);
            this.Controls.Add(this.rdMa);
            this.Controls.Add(this.rdTen);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lbTimKiem);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.RadioButton rdSDT;
        private System.Windows.Forms.Button btnSearch;
    }
}