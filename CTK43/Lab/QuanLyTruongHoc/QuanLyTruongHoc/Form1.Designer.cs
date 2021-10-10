
namespace QuanLyTruongHoc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadJsonDatatsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIn = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tvKhoa = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbSDT = new System.Windows.Forms.RadioButton();
            this.rbHoTen = new System.Windows.Forms.RadioButton();
            this.rbMSSV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSV = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Khoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNhap,
            this.tsmLuu,
            this.tsmIn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1371, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmNhap
            // 
            this.tsmNhap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReadJsonDatatsmi});
            this.tsmNhap.Name = "tsmNhap";
            this.tsmNhap.Size = new System.Drawing.Size(48, 20);
            this.tsmNhap.Text = "Nhập";
            // 
            // ReadJsonDatatsmi
            // 
            this.ReadJsonDatatsmi.Name = "ReadJsonDatatsmi";
            this.ReadJsonDatatsmi.Size = new System.Drawing.Size(124, 22);
            this.ReadJsonDatatsmi.Text = "Json Data";
            // 
            // tsmLuu
            // 
            this.tsmLuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.tsmLuu.Name = "tsmLuu";
            this.tsmLuu.Size = new System.Drawing.Size(39, 20);
            this.tsmLuu.Text = "Lưu";
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.jsonToolStripMenuItem.Text = "Json";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // tsmIn
            // 
            this.tsmIn.Name = "tsmIn";
            this.tsmIn.Size = new System.Drawing.Size(29, 20);
            this.tsmIn.Text = "In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn lớp để hiển thị danh sách sinh viên";
            // 
            // tvKhoa
            // 
            this.tvKhoa.Location = new System.Drawing.Point(18, 135);
            this.tvKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.tvKhoa.Name = "tvKhoa";
            this.tvKhoa.Size = new System.Drawing.Size(330, 748);
            this.tvKhoa.TabIndex = 5;
            this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoa_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.rbSDT);
            this.groupBox1.Controls.Add(this.rbHoTen);
            this.groupBox1.Controls.Add(this.rbMSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lvSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(358, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1002, 858);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(361, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 24);
            this.txtSearch.TabIndex = 5;
            // 
            // rbSDT
            // 
            this.rbSDT.AutoSize = true;
            this.rbSDT.Location = new System.Drawing.Point(583, 37);
            this.rbSDT.Margin = new System.Windows.Forms.Padding(4);
            this.rbSDT.Name = "rbSDT";
            this.rbSDT.Size = new System.Drawing.Size(125, 22);
            this.rbSDT.TabIndex = 4;
            this.rbSDT.TabStop = true;
            this.rbSDT.Text = "Số điện thoại";
            this.rbSDT.UseVisualStyleBackColor = true;
            // 
            // rbHoTen
            // 
            this.rbHoTen.AutoSize = true;
            this.rbHoTen.Location = new System.Drawing.Point(470, 37);
            this.rbHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.rbHoTen.Name = "rbHoTen";
            this.rbHoTen.Size = new System.Drawing.Size(76, 22);
            this.rbHoTen.TabIndex = 3;
            this.rbHoTen.TabStop = true;
            this.rbHoTen.Text = "Họ tên";
            this.rbHoTen.UseVisualStyleBackColor = true;
            // 
            // rbMSSV
            // 
            this.rbMSSV.AutoSize = true;
            this.rbMSSV.Location = new System.Drawing.Point(361, 35);
            this.rbMSSV.Margin = new System.Windows.Forms.Padding(4);
            this.rbMSSV.Name = "rbMSSV";
            this.rbMSSV.Size = new System.Drawing.Size(72, 22);
            this.rbMSSV.TabIndex = 2;
            this.rbMSSV.TabStop = true;
            this.rbMSSV.Text = "MSSV";
            this.rbMSSV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm theo:";
            // 
            // lvSV
            // 
            this.lvSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.Ho,
            this.Ten,
            this.GioiTinh,
            this.NgaySinh,
            this.Sdt,
            this.Lop,
            this.Khoa,
            this.DiaChi});
            this.lvSV.FullRowSelect = true;
            this.lvSV.GridLines = true;
            this.lvSV.HideSelection = false;
            this.lvSV.Location = new System.Drawing.Point(0, 109);
            this.lvSV.Margin = new System.Windows.Forms.Padding(4);
            this.lvSV.Name = "lvSV";
            this.lvSV.Size = new System.Drawing.Size(998, 748);
            this.lvSV.TabIndex = 0;
            this.lvSV.UseCompatibleStateImageBehavior = false;
            this.lvSV.View = System.Windows.Forms.View.Details;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            this.MSSV.Width = 77;
            // 
            // Ho
            // 
            this.Ho.Text = "Họ và tên lót";
            this.Ho.Width = 232;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên";
            this.Ten.Width = 108;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới tính";
            this.GioiTinh.Width = 95;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày sinh";
            this.NgaySinh.Width = 120;
            // 
            // Sdt
            // 
            this.Sdt.Text = "Số điện thoại";
            this.Sdt.Width = 148;
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            this.Lop.Width = 223;
            // 
            // Khoa
            // 
            this.Khoa.Text = "Khoa";
            this.Khoa.Width = 202;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 892);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvKhoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmNhap;
        private System.Windows.Forms.ToolStripMenuItem ReadJsonDatatsmi;
        private System.Windows.Forms.ToolStripMenuItem tsmLuu;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbSDT;
        private System.Windows.Forms.RadioButton rbHoTen;
        private System.Windows.Forms.RadioButton rbMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSV;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader Ho;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader Sdt;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.ColumnHeader Khoa;
        private System.Windows.Forms.ColumnHeader DiaChi;
    }
}

