
namespace OnTapKiemTra1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbSDT = new System.Windows.Forms.RadioButton();
            this.rbHoTen = new System.Windows.Forms.RadioButton();
            this.rbMSSV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tvKhoa = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.cmsListView.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(358, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1002, 858);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(361, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 24);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSV.ContextMenuStrip = this.cmsListView;
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
            this.lvSV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSV_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên lót";
            this.columnHeader2.Width = 232;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày sinh";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 148;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lớp";
            this.columnHeader7.Width = 223;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Khoa";
            this.columnHeader8.Width = 202;
            // 
            // cmsListView
            // 
            this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiThem,
            this.tsmiXoa});
            this.cmsListView.Name = "cmsListView";
            this.cmsListView.Size = new System.Drawing.Size(105, 48);
            // 
            // tsmiThem
            // 
            this.tsmiThem.Name = "tsmiThem";
            this.tsmiThem.Size = new System.Drawing.Size(104, 22);
            this.tsmiThem.Text = "Thêm";
            this.tsmiThem.Click += new System.EventHandler(this.tsmiThem_Click);
            // 
            // tsmiXoa
            // 
            this.tsmiXoa.Name = "tsmiXoa";
            this.tsmiXoa.Size = new System.Drawing.Size(104, 22);
            this.tsmiXoa.Text = "Xóa";
            this.tsmiXoa.Click += new System.EventHandler(this.tsmiXoa_Click);
            // 
            // tvKhoa
            // 
            this.tvKhoa.Location = new System.Drawing.Point(18, 126);
            this.tvKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.tvKhoa.Name = "tvKhoa";
            this.tvKhoa.Size = new System.Drawing.Size(330, 748);
            this.tvKhoa.TabIndex = 1;
            this.tvKhoa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKhoa_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn lớp để hiển thị danh sách sinh viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 892);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvKhoa);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "OnTapKiemTra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TreeView tvKhoa;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbSDT;
        private System.Windows.Forms.RadioButton rbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip cmsListView;
        private System.Windows.Forms.ToolStripMenuItem tsmiThem;
        private System.Windows.Forms.ToolStripMenuItem tsmiXoa;
    }
}

