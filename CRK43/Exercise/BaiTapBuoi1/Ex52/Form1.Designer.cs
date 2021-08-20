
namespace Ex52
{
    partial class listBox
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
            this.lbSelection = new System.Windows.Forms.Label();
            this.lbExtended = new System.Windows.Forms.Label();
            this.listSinhVien = new System.Windows.Forms.ListBox();
            this.listDanhSach = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSelection
            // 
            this.lbSelection.AutoSize = true;
            this.lbSelection.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelection.Location = new System.Drawing.Point(22, 29);
            this.lbSelection.Name = "lbSelection";
            this.lbSelection.Size = new System.Drawing.Size(187, 19);
            this.lbSelection.TabIndex = 0;
            this.lbSelection.Text = "Danh sách sinh viên lớp";
            // 
            // lbExtended
            // 
            this.lbExtended.AutoSize = true;
            this.lbExtended.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtended.Location = new System.Drawing.Point(341, 29);
            this.lbExtended.Name = "lbExtended";
            this.lbExtended.Size = new System.Drawing.Size(325, 19);
            this.lbExtended.TabIndex = 1;
            this.lbExtended.Text = "Danh sách sinh viên lớp tham gia bóng đá";
            // 
            // listSinhVien
            // 
            this.listSinhVien.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSinhVien.FormattingEnabled = true;
            this.listSinhVien.ItemHeight = 20;
            this.listSinhVien.Location = new System.Drawing.Point(26, 71);
            this.listSinhVien.Name = "listSinhVien";
            this.listSinhVien.Size = new System.Drawing.Size(249, 284);
            this.listSinhVien.TabIndex = 2;
            // 
            // listDanhSach
            // 
            this.listDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDanhSach.FormattingEnabled = true;
            this.listDanhSach.ItemHeight = 18;
            this.listDanhSach.Location = new System.Drawing.Point(391, 71);
            this.listDanhSach.Name = "listDanhSach";
            this.listDanhSach.Size = new System.Drawing.Size(256, 292);
            this.listDanhSach.TabIndex = 3;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(294, 124);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(294, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // listBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 395);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.listDanhSach);
            this.Controls.Add(this.listSinhVien);
            this.Controls.Add(this.lbExtended);
            this.Controls.Add(this.lbSelection);
            this.Name = "listBox";
            this.Text = "Demo listbox";
            this.Load += new System.EventHandler(this.listBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSelection;
        private System.Windows.Forms.Label lbExtended;
        private System.Windows.Forms.ListBox listSinhVien;
        private System.Windows.Forms.ListBox listDanhSach;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
    }
}

