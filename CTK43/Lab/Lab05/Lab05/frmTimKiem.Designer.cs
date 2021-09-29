
namespace Lab05
{
    partial class frmTimKiem
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
            this.cbbKieu = new Guna.UI.WinForms.GunaComboBox();
            this.txtGiaTri = new Guna.UI.WinForms.GunaTextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm theo";
            // 
            // cbbKieu
            // 
            this.cbbKieu.BackColor = System.Drawing.Color.Transparent;
            this.cbbKieu.BaseColor = System.Drawing.Color.White;
            this.cbbKieu.BorderColor = System.Drawing.Color.Silver;
            this.cbbKieu.BorderSize = 1;
            this.cbbKieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKieu.FocusedColor = System.Drawing.Color.Empty;
            this.cbbKieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbKieu.ForeColor = System.Drawing.Color.Black;
            this.cbbKieu.FormattingEnabled = true;
            this.cbbKieu.Items.AddRange(new object[] {
            "Tên",
            "Lớp",
            "MSSV"});
            this.cbbKieu.Location = new System.Drawing.Point(112, 25);
            this.cbbKieu.Name = "cbbKieu";
            this.cbbKieu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbKieu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbKieu.Size = new System.Drawing.Size(149, 26);
            this.cbbKieu.TabIndex = 1;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.BaseColor = System.Drawing.Color.White;
            this.txtGiaTri.BorderColor = System.Drawing.Color.Silver;
            this.txtGiaTri.BorderSize = 1;
            this.txtGiaTri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTri.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGiaTri.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGiaTri.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGiaTri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaTri.Location = new System.Drawing.Point(267, 25);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.PasswordChar = '\0';
            this.txtGiaTri.SelectedText = "";
            this.txtGiaTri.Size = new System.Drawing.Size(272, 26);
            this.txtGiaTri.TabIndex = 2;
            this.txtGiaTri.Text = "\r\n";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(562, 22);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 31);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 450);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lvSV
            // 
            this.lvSV.CheckBoxes = true;
            this.lvSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSV.FullRowSelect = true;
            this.lvSV.GridLines = true;
            this.lvSV.HideSelection = false;
            this.lvSV.Location = new System.Drawing.Point(3, 16);
            this.lvSV.Name = "lvSV";
            this.lvSV.Size = new System.Drawing.Size(901, 431);
            this.lvSV.TabIndex = 1;
            this.lvSV.UseCompatibleStateImageBehavior = false;
            this.lvSV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên lót";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số CMND";
            this.columnHeader6.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Số điện thoại";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Địa chỉ liên lạc";
            this.columnHeader8.Width = 174;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giới tính";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Môn đăng ký";
            this.columnHeader10.Width = 151;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.cbbKieu);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cbbKieu;
        private Guna.UI.WinForms.GunaTextBox txtGiaTri;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}