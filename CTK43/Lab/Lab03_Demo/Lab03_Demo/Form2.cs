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

namespace Lab03_Demo
{
    public partial class frmTuyChon : Form
    {
        QuanLySinhVien qlsv;
        ListView lv;
        public frmTuyChon()
        {
            InitializeComponent();
        }

        public frmTuyChon(QuanLySinhVien qlsv, ListView lv, bool loai)
        {
            InitializeComponent();
            this.qlsv = qlsv;
            this.lv = lv;

            if (loai)
                btnSort.Enabled = false;
            else
            {
                label1.Enabled = false;
                txtNhap.Enabled = false;
                btnSearch.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SinhVien sv = null;
            Kieu kieu = Kieu.TheoMa;
            if (rdMa.Checked)
                kieu = Kieu.TheoMa;
            if (rdHoTen.Checked)
                kieu = Kieu.TheoTen;
            if (rdNgaySinh.Checked)
                kieu = Kieu.TheoNS;

            switch (kieu)
            {
                case Kieu.TheoTen:
                    sv = qlsv.dsSinhVien.Find(x => x.HoTen == txtNhap.Text);
                    break;
                case Kieu.TheoMa:
                    sv = qlsv.dsSinhVien.Find(x => x.MaSo == txtNhap.Text);
                    break;
                case Kieu.TheoNS:
                    sv = qlsv.dsSinhVien.Find(x => x.NgaySinh.Day == int.Parse(txtNhap.Text));
                    break;
                default:
                    break;
            }
            if (sv is null)
                MessageBox.Show("Khong tim thay sinh vien", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                ListViewItem item = new ListViewItem(sv.MaSo);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
                item.SubItems.Add(sv.Hinh);

                lv.Items.Clear();
                lv.Items.Add(item);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Kieu kieu = Kieu.TheoMa;
            if (rdMa.Checked)
                kieu = Kieu.TheoMa;
            if (rdHoTen.Checked)
                kieu = Kieu.TheoTen;
            if (rdNgaySinh.Checked)
                kieu = Kieu.TheoNS;

            switch (kieu)
            {
                case Kieu.TheoTen:
                    qlsv.dsSinhVien.Sort((x, y) => x.HoTen.CompareTo(y.HoTen));
                    break;
                case Kieu.TheoMa:
                    qlsv.dsSinhVien.Sort((x, y) => x.MaSo.CompareTo(y.MaSo));
                    break;
                case Kieu.TheoNS:
                    qlsv.dsSinhVien.Sort((x, y) => x.NgaySinh.CompareTo(y.NgaySinh));
                    break;
                default:
                    break;
            }
            lv.Items.Clear();
            foreach (var sv in qlsv.dsSinhVien)
            {
                ListViewItem item = new ListViewItem(sv.MaSo);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(String.Join(", ", sv.ChuyenNganh));
                item.SubItems.Add(sv.Hinh);

                lv.Items.Add(item);
            }
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nhập Mã";
            txtNhap.Text = "";
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nhập Tên";
            txtNhap.Text = "";
        }

        private void rdNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Nhập Ngày";
            txtNhap.Text = "";
        }
    }
}
