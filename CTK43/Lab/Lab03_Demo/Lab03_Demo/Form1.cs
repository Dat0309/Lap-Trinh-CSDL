using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab03_Demo.File;
using System.IO;

namespace Lab03_Demo
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        #region cac ham chuc nang

        #region Lay thong tin sinh vien  tu control 
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = rdNam.Checked ? true : false;
            List<string> chuyenNganh = new List<string>();
            sv.MaSo = this.mtbMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cbbLop.Text;
            sv.Hinh = this.txtHinh.Text;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                if (clbChuyenNganh.GetItemChecked(i))
                    chuyenNganh.Add(clbChuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = chuyenNganh;
            return sv;
        }
        #endregion
        #region Lay thong tin sinh vien tu dong item cua ListView
        private SinhVien GetSinhVienLV(ListViewItem item)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = item.SubItems[0].Text;
            sv.HoTen = item.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(item.SubItems[2].Text);
            sv.DiaChi = item.SubItems[3].Text;
            sv.Lop = item.SubItems[4].Text;
            sv.GioiTinh = (item.SubItems[5].Text == "Nam" ? true : false);
            List<string> chuyenNganh = new List<string>();
            string[] s = item.SubItems[6].Text.Split(',');
            foreach (string t in s)
                chuyenNganh.Add(t);
            sv.ChuyenNganh = chuyenNganh;
            sv.Hinh = item.SubItems[7].Text;
            return sv;
        }
        #endregion
        #region Thiet lap cac thong tin len control sinh vien
        private void ThietLapThognTin(SinhVien sv)
        {
            this.mtbMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cbbLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            this.rdNam.Checked = (sv.GioiTinh == true ? true : false);
            this.rdNu.Checked = (sv.GioiTinh == false ? true : false);

            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                    if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                        this.clbChuyenNganh.SetItemChecked(i, true);
            }
        }
        #endregion
        #region Them sinh vien vao list view
        private void ThemSV(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.MaSo);
            item.SubItems.Add(sv.HoTen);
            item.SubItems.Add(sv.NgaySinh.ToShortDateString());
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.Lop);
            string gt = (sv.GioiTinh == true ? "Nam" : "Nu");
            item.SubItems.Add(gt);
            string chuyenNganh = "";
            foreach (string s in sv.ChuyenNganh)
                chuyenNganh += s + ",";
            chuyenNganh = chuyenNganh.Substring(0, chuyenNganh.Length - 1);
            item.SubItems.Add(chuyenNganh);
            item.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(item);
        }
        #endregion
        #region Hien thi cac sinh vien trong qlsv len listview
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                ThemSV(sv);
            }
        }


        #endregion

        #endregion

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if(count>0)
            {
                ListViewItem item = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(item);
                ThietLapThognTin(sv);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2) {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữliệu",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem item;
            count = this.lvSinhVien.Items.Count - 1;
            for(i = count; i>=0; i--)
            {
                item = this.lvSinhVien.Items[i];
                if (item.Checked)
                    qlsv.Xoa(item.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtbMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cbbLop.Text = this.cbbLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kquaSua;
            kquaSua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kquaSua)
            {
                this.LoadListView();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Open File Image";
            file.Filter = "Image Files (BMP, JPEG, PNG)|"
                + "*.bmp;*.jpg;*.jpeg;*.png|"
                + "BMP files (*.bmp)|*.bmp|"
                + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
                + "PNG files (*.png)|*.png|"
                + "All files (*.*)|*.*";
            file.InitialDirectory = Environment.CurrentDirectory;
            if(file.ShowDialog() == DialogResult.OK)
            {
                var fileName = file.FileName;
                txtHinh.Text = fileName;
                pbHinh.Load(fileName);
            }
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBrowse.PerformClick();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThoat.PerformClick();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem.PerformClick();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoa.PerformClick();
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSua.PerformClick();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = fontDialog1;
            var ok = fontDialog.ShowDialog();
            if (ok == DialogResult.OK)
                lvSinhVien.Font = fontDialog.Font;
        }

        private void màuChữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = colorDialog1;
            var ok = colorDialog.ShowDialog();
            if (ok == DialogResult.OK)
                lvSinhVien.ForeColor = colorDialog.Color;
        }

        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon(qlsv, lvSinhVien, false);
            frm.ShowDialog();
            
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon(qlsv, lvSinhVien, true);
            frm.ShowDialog();
        }
    }
}
