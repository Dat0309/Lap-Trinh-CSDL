
namespace Lab04_Aplication
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
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChoHinh = new Guna.UI.WinForms.GunaButton();
            this.btnMacDinh = new Guna.UI.WinForms.GunaButton();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.txtHoTen = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtDiaChi = new Guna.UI.WinForms.GunaTextBox();
            this.txtHinh = new Guna.UI.WinForms.GunaTextBox();
            this.mtbMSSV = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dpkNgaySinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.rbNam = new Guna.UI.WinForms.GunaRadioButton();
            this.rbNu = new Guna.UI.WinForms.GunaRadioButton();
            this.cbbLop = new Guna.UI.WinForms.GunaComboBox();
            this.mtbSdt = new System.Windows.Forms.MaskedTextBox();
            this.lvSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoad = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.Location = new System.Drawing.Point(12, 12);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(196, 270);
            this.pbHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHinhAnh.TabIndex = 0;
            this.pbHinhAnh.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbSdt);
            this.groupBox1.Controls.Add(this.cbbLop);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.dpkNgaySinh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mtbMSSV);
            this.groupBox1.Controls.Add(this.txtHinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnMacDinh);
            this.groupBox1.Controls.Add(this.btnChoHinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(223, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvSV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 270);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hình";
            // 
            // btnChoHinh
            // 
            this.btnChoHinh.AnimationHoverSpeed = 0.07F;
            this.btnChoHinh.AnimationSpeed = 0.03F;
            this.btnChoHinh.BackColor = System.Drawing.Color.Transparent;
            this.btnChoHinh.BaseColor = System.Drawing.Color.SlateGray;
            this.btnChoHinh.BorderColor = System.Drawing.Color.Black;
            this.btnChoHinh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChoHinh.FocusedColor = System.Drawing.Color.Empty;
            this.btnChoHinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChoHinh.ForeColor = System.Drawing.Color.White;
            this.btnChoHinh.Image = null;
            this.btnChoHinh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChoHinh.Location = new System.Drawing.Point(734, 193);
            this.btnChoHinh.Name = "btnChoHinh";
            this.btnChoHinh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChoHinh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChoHinh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChoHinh.OnHoverImage = null;
            this.btnChoHinh.OnPressedColor = System.Drawing.Color.Black;
            this.btnChoHinh.Radius = 5;
            this.btnChoHinh.Size = new System.Drawing.Size(106, 29);
            this.btnChoHinh.TabIndex = 9;
            this.btnChoHinh.Text = "Chọn hình";
            this.btnChoHinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChoHinh.Click += new System.EventHandler(this.btnChoHinh_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.AnimationHoverSpeed = 0.07F;
            this.btnMacDinh.AnimationSpeed = 0.03F;
            this.btnMacDinh.BackColor = System.Drawing.Color.Transparent;
            this.btnMacDinh.BaseColor = System.Drawing.Color.SlateGray;
            this.btnMacDinh.BorderColor = System.Drawing.Color.Black;
            this.btnMacDinh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMacDinh.FocusedColor = System.Drawing.Color.Empty;
            this.btnMacDinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMacDinh.ForeColor = System.Drawing.Color.White;
            this.btnMacDinh.Image = null;
            this.btnMacDinh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMacDinh.Location = new System.Drawing.Point(490, 235);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMacDinh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMacDinh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMacDinh.OnHoverImage = null;
            this.btnMacDinh.OnPressedColor = System.Drawing.Color.Black;
            this.btnMacDinh.Radius = 5;
            this.btnMacDinh.Size = new System.Drawing.Size(106, 29);
            this.btnMacDinh.TabIndex = 10;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BaseColor = System.Drawing.Color.SlateGray;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = null;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(612, 235);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Radius = 5;
            this.btnLuu.Size = new System.Drawing.Size(106, 29);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BaseColor = System.Drawing.Color.SlateGray;
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = null;
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(734, 235);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Radius = 5;
            this.btnThoat.Size = new System.Drawing.Size(106, 29);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.Transparent;
            this.txtHoTen.BaseColor = System.Drawing.Color.White;
            this.txtHoTen.BorderColor = System.Drawing.Color.Black;
            this.txtHoTen.BorderSize = 1;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHoTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtHoTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(127, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.Radius = 3;
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(336, 30);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(127, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 3;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(336, 30);
            this.txtEmail.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.txtDiaChi.BaseColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderColor = System.Drawing.Color.Black;
            this.txtDiaChi.BorderSize = 1;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDiaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDiaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.Location = new System.Drawing.Point(127, 151);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.Radius = 3;
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(336, 30);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtHinh
            // 
            this.txtHinh.BackColor = System.Drawing.Color.Transparent;
            this.txtHinh.BaseColor = System.Drawing.SystemColors.Control;
            this.txtHinh.BorderColor = System.Drawing.Color.Black;
            this.txtHinh.BorderSize = 1;
            this.txtHinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHinh.Enabled = false;
            this.txtHinh.FocusedBaseColor = System.Drawing.Color.White;
            this.txtHinh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtHinh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHinh.Location = new System.Drawing.Point(127, 193);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.PasswordChar = '\0';
            this.txtHinh.Radius = 3;
            this.txtHinh.ReadOnly = true;
            this.txtHinh.SelectedText = "";
            this.txtHinh.Size = new System.Drawing.Size(591, 30);
            this.txtHinh.TabIndex = 13;
            // 
            // mtbMSSV
            // 
            this.mtbMSSV.Location = new System.Drawing.Point(127, 26);
            this.mtbMSSV.Mask = "0000000";
            this.mtbMSSV.Name = "mtbMSSV";
            this.mtbMSSV.Size = new System.Drawing.Size(101, 22);
            this.mtbMSSV.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(487, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(487, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(487, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(487, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại";
            // 
            // dpkNgaySinh
            // 
            this.dpkNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.dpkNgaySinh.BaseColor = System.Drawing.Color.White;
            this.dpkNgaySinh.BorderColor = System.Drawing.Color.Black;
            this.dpkNgaySinh.BorderSize = 1;
            this.dpkNgaySinh.CustomFormat = "dd/mm/yyyy";
            this.dpkNgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpkNgaySinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dpkNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpkNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.dpkNgaySinh.Location = new System.Drawing.Point(612, 32);
            this.dpkNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpkNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpkNgaySinh.Name = "dpkNgaySinh";
            this.dpkNgaySinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.dpkNgaySinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dpkNgaySinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dpkNgaySinh.OnPressedColor = System.Drawing.Color.Black;
            this.dpkNgaySinh.Radius = 3;
            this.dpkNgaySinh.Size = new System.Drawing.Size(228, 22);
            this.dpkNgaySinh.TabIndex = 4;
            this.dpkNgaySinh.Text = "Tuesday, September 21, 2021";
            this.dpkNgaySinh.Value = new System.DateTime(2021, 9, 21, 7, 49, 48, 320);
            // 
            // rbNam
            // 
            this.rbNam.BaseColor = System.Drawing.SystemColors.Control;
            this.rbNam.Checked = true;
            this.rbNam.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbNam.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbNam.FillColor = System.Drawing.Color.White;
            this.rbNam.Location = new System.Drawing.Point(659, 75);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(59, 20);
            this.rbNam.TabIndex = 5;
            this.rbNam.Text = "Nam";
            // 
            // rbNu
            // 
            this.rbNu.BaseColor = System.Drawing.SystemColors.Control;
            this.rbNu.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbNu.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbNu.FillColor = System.Drawing.Color.White;
            this.rbNu.Location = new System.Drawing.Point(734, 75);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 20);
            this.rbNu.TabIndex = 6;
            this.rbNu.Text = "Nữ";
            // 
            // cbbLop
            // 
            this.cbbLop.BackColor = System.Drawing.Color.Transparent;
            this.cbbLop.BaseColor = System.Drawing.Color.LightGray;
            this.cbbLop.BorderColor = System.Drawing.Color.Black;
            this.cbbLop.BorderSize = 1;
            this.cbbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FocusedColor = System.Drawing.Color.Empty;
            this.cbbLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLop.ForeColor = System.Drawing.Color.Black;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45"});
            this.cbbLop.Location = new System.Drawing.Point(612, 112);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbLop.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbLop.Radius = 3;
            this.cbbLop.Size = new System.Drawing.Size(228, 26);
            this.cbbLop.TabIndex = 7;
            // 
            // mtbSdt
            // 
            this.mtbSdt.Location = new System.Drawing.Point(612, 157);
            this.mtbSdt.Mask = "0000.000.000";
            this.mtbSdt.Name = "mtbSdt";
            this.mtbSdt.Size = new System.Drawing.Size(228, 22);
            this.mtbSdt.TabIndex = 8;
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
            this.columnHeader8,
            this.columnHeader9});
            this.lvSV.ContextMenuStrip = this.contextMenuStrip1;
            this.lvSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSV.FullRowSelect = true;
            this.lvSV.GridLines = true;
            this.lvSV.HideSelection = false;
            this.lvSV.Location = new System.Drawing.Point(3, 18);
            this.lvSV.Name = "lvSV";
            this.lvSV.Size = new System.Drawing.Size(1051, 249);
            this.lvSV.TabIndex = 0;
            this.lvSV.UseCompatibleStateImageBehavior = false;
            this.lvSV.View = System.Windows.Forms.View.Details;
            this.lvSV.SelectedIndexChanged += new System.EventHandler(this.lvSV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phái";
            this.columnHeader3.Width = 62;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            this.columnHeader5.Width = 66;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Địa chỉ";
            this.columnHeader8.Width = 246;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Hình";
            this.columnHeader9.Width = 97;
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXoa,
            this.tsmLoad});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmXoa
            // 
            this.tsmXoa.Name = "tsmXoa";
            this.tsmXoa.Size = new System.Drawing.Size(180, 22);
            this.tsmXoa.Text = "Xóa";
            this.tsmXoa.Click += new System.EventHandler(this.tsmXoa_Click);
            // 
            // tsmLoad
            // 
            this.tsmLoad.Name = "tsmLoad";
            this.tsmLoad.Size = new System.Drawing.Size(180, 22);
            this.tsmLoad.Text = "Tải lại danh sách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1081, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbHinhAnh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHinhAnh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbSdt;
        private Guna.UI.WinForms.GunaComboBox cbbLop;
        private Guna.UI.WinForms.GunaRadioButton rbNu;
        private Guna.UI.WinForms.GunaRadioButton rbNam;
        private Guna.UI.WinForms.GunaDateTimePicker dpkNgaySinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbMSSV;
        private Guna.UI.WinForms.GunaTextBox txtHinh;
        private Guna.UI.WinForms.GunaTextBox txtDiaChi;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtHoTen;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private Guna.UI.WinForms.GunaButton btnLuu;
        private Guna.UI.WinForms.GunaButton btnMacDinh;
        private Guna.UI.WinForms.GunaButton btnChoHinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvSV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmLoad;
    }
}

