
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.btnSearchCode = new System.Windows.Forms.Button();
            this.btnSearchSDT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(147, 29);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(381, 20);
            this.txtKey.TabIndex = 1;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.Location = new System.Drawing.Point(68, 106);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(113, 33);
            this.btnSearchName.TabIndex = 2;
            this.btnSearchName.Text = "Tìm theo tên";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // btnSearchCode
            // 
            this.btnSearchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCode.Location = new System.Drawing.Point(259, 106);
            this.btnSearchCode.Name = "btnSearchCode";
            this.btnSearchCode.Size = new System.Drawing.Size(113, 33);
            this.btnSearchCode.TabIndex = 3;
            this.btnSearchCode.Text = "Tìm theo mã số";
            this.btnSearchCode.UseVisualStyleBackColor = true;
            this.btnSearchCode.Click += new System.EventHandler(this.btnSearchCode_Click);
            // 
            // btnSearchSDT
            // 
            this.btnSearchSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSDT.Location = new System.Drawing.Point(448, 106);
            this.btnSearchSDT.Name = "btnSearchSDT";
            this.btnSearchSDT.Size = new System.Drawing.Size(113, 33);
            this.btnSearchSDT.TabIndex = 4;
            this.btnSearchSDT.Text = "Tìm theo sdt";
            this.btnSearchSDT.UseVisualStyleBackColor = true;
            this.btnSearchSDT.Click += new System.EventHandler(this.btnSearchSDT_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 166);
            this.Controls.Add(this.btnSearchSDT);
            this.Controls.Add(this.btnSearchCode);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Button btnSearchCode;
        private System.Windows.Forms.Button btnSearchSDT;
    }
}