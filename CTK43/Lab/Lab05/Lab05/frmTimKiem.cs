using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05.Model;

namespace Lab05
{
    public partial class frmTimKiem : Form
    {
        QLSV qlsv;
        List<SinhVien> dskq;
        public frmTimKiem(QLSV qlsv)
        {
            InitializeComponent();
            this.qlsv = qlsv;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dskq = new List<SinhVien>();
            SinhVien sv = null;
            if (cbbKieu.Text.CompareTo("MSSV") == 0)
            {
                sv = qlsv.Tim(txtGiaTri.Text.Trim(), SoSanhTheoMa);
                dskq.Add(sv);
            }
            else if (cbbKieu.Text.CompareTo("Tên") == 0)
            {
                dskq = qlsv.DSTim(txtGiaTri.Text.Trim(), SoSanhTheoTen);
            }
            else if (cbbKieu.Text.CompareTo("Lớp") == 0)
            {
                dskq = qlsv.DSTim(txtGiaTri.Text.Trim(), SoSanhTheoLop);
            }

            if (dskq == null)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LoadSVToListView(dskq);
            }

        }

        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.mssv.CompareTo(obj1.ToString());
        }
        private int SoSanhTheoTen(object obj1, object obj2)
        {
            return (obj2 as SinhVien).ten.CompareTo(obj1.ToString());
        }
        private int SoSanhTheoLop(object obj1, object obj2)
        {
            return (obj2 as SinhVien).lop.CompareTo(obj1.ToString());
        }

        private void ThemSV(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.mssv);
            item.SubItems.Add(sv.ho);
            item.SubItems.Add(sv.ten);
            item.SubItems.Add(sv.ngaySinh.ToShortDateString());
            item.SubItems.Add(sv.lop);
            item.SubItems.Add(sv.cmnd);
            item.SubItems.Add(sv.sdt);
            item.SubItems.Add(sv.diaChi);
            item.SubItems.Add(sv.gioiTinh == true ? "Nam" : "Nu");
            item.SubItems.Add(string.Join(",", sv.monHoc));

            lvSV.Items.Add(item);
        }

        private void LoadSVToListView(List<SinhVien> danhsach)
        {
            lvSV.Items.Clear();
            foreach (SinhVien sv in danhsach)
                ThemSV(sv);
        }
    }
}
