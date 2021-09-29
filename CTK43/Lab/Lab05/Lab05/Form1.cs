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
    public partial class Form1 : Form
    {
        Context context;
        private List<string> dsMon;
        private List<SinhVien> dssv;
        QLSV qlsv;

        public Form1(Context context)
        {
            InitializeComponent();
            this.context = context;
            dssv = context.GetSV();
            dsMon = new List<string>
            {
                "Mạng máy tính",
                "Hệ điều hành",
                "Lập trình CSDL",
                "Lập trình mạng",
                "Đồ án cơ sở",
                "Phương pháp NCKH",
                "Lập trình trên thiết bị di động",
                "An toàn và bảo mật hệ thống"
            };
        }

        #region Định nghĩa các hàm xử lý

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

        private SinhVien GetSVLV(ListViewItem item)
        {
            SinhVien sv = new SinhVien();
            sv.mssv = item.SubItems[0].Text;
            sv.ho = item.SubItems[1].Text;
            sv.ten = item.SubItems[2].Text;
            sv.ngaySinh = DateTime.Parse(item.SubItems[3].Text);
            sv.lop = item.SubItems[4].Text;
            sv.cmnd = item.SubItems[5].Text;
            sv.sdt = item.SubItems[6].Text;
            sv.diaChi = item.SubItems[7].Text;
            sv.gioiTinh = item.SubItems[8].Text == "Nam" ? true : false;
            sv.monHoc = new List<string>(item.SubItems[9].Text.Split(new string[] { "," }, StringSplitOptions.None));

            return sv;
        }

        private void ThietLapControl(SinhVien sv)
        {
            mtbMSSV.Text = sv.mssv;
            txtHo.Text = sv.ho;
            txtTen.Text = sv.ten;
            dtpNgaySinh.Value = sv.ngaySinh;
            cbbLop.Text = sv.lop;
            mtbCMND.Text = sv.cmnd;
            mtbSDT.Text = sv.sdt;
            txtDiaChi.Text = sv.diaChi;
            rbNam.Checked = (sv.gioiTinh == true ? true : false);
            rbNu.Checked = (sv.gioiTinh == false ? true : false);
            for (int i = 0; i < clbDKM.Items.Count; i++)
                clbDKM.SetItemChecked(i, false);
            foreach(var mh in sv.monHoc)
            {
                for(int i=0;i< clbDKM.Items.Count; i++)
                {
                    if (clbDKM.Items[i].ToString().CompareTo(mh) == 0)
                        clbDKM.SetItemChecked(i, true);
                }
            }
        }

        private SinhVien GetSVControl()
        {
            SinhVien sv = new SinhVien();
            sv.mssv = mtbMSSV.Text;
            sv.ho = txtHo.Text;
            sv.ten = txtTen.Text;
            sv.ngaySinh = dtpNgaySinh.Value;
            sv.lop = cbbLop.Text;
            sv.cmnd = mtbCMND.Text;
            sv.sdt = mtbSDT.Text;
            sv.diaChi = txtDiaChi.Text;
            sv.gioiTinh = (rbNam.Checked == true ? true : false);
            List<string> dsmh = new List<string>();
            foreach (var item in clbDKM.CheckedItems)
            {
                dsmh.Add(item as string);
            }
            sv.monHoc = dsmh;
            return sv;
        }

        private SinhVien UpdateSV(SinhVien sv)
        {
            SinhVien svUpdate = GetSVControl();
            sv.mssv = svUpdate.mssv;
            sv.ho = svUpdate.ho;
            sv.ten = svUpdate.ten;
            sv.ngaySinh = svUpdate.ngaySinh;
            sv.lop = svUpdate.lop;
            sv.cmnd = svUpdate.cmnd;
            sv.sdt = svUpdate.sdt;
            sv.diaChi = svUpdate.diaChi;
            sv.gioiTinh = svUpdate.gioiTinh;
            sv.monHoc = svUpdate.monHoc;
            return sv;
        }

        private void ClearForm()
        {
            mtbMSSV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cbbLop.Text = "";
            mtbCMND.Text = "";
            mtbSDT.Text = "";
            txtDiaChi.Text = "";
            rbNam.Checked = false;
            rbNu.Checked = false;
            for (int i = 0; i < clbDKM.Items.Count; i++)
                clbDKM.SetItemChecked(i, false);
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtHo.Text)) return false;
            else if (string.IsNullOrEmpty(txtTen.Text)) return false;
            else if (string.IsNullOrEmpty(txtDiaChi.Text)) return false;
            else if (string.IsNullOrEmpty(mtbMSSV.Text)) return false;
            else if (string.IsNullOrEmpty(mtbCMND.Text)) return false;
            else if (string.IsNullOrEmpty(mtbSDT.Text)) return false;
            else if (string.IsNullOrEmpty(cbbLop.Text)) return false;
            else if (rbNam.Checked == false && rbNu.Checked == false) return false;
            else if (clbDKM.CheckedItems.Count == 0) return false;
            else return true;
        }
        private bool ValidationEqualTo(string value, int l)
        {
            if (value.Length == l)
                return true;
            return false;
        }

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in dsMon)
                clbDKM.Items.Add(item, false);
            qlsv = new QLSV(context);
            LoadSVToListView(qlsv.dssv);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Cậu có chắc không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dlg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = qlsv.Tim(GetSVControl().mssv, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).mssv.CompareTo(obj1.ToString());
            });
            if (Validation())
            {
                    DialogResult dlg = MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dlg == DialogResult.Yes)
                    {
                        UpdateSV(sv);
                        LoadSVToListView(qlsv.dssv);
                        context.SaveSV();
                        MessageBox.Show("Cập nhật sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem(qlsv);
            frm.ShowDialog();
        }

        private void lvSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem item = lvSV.SelectedItems[0];
                ThietLapControl(GetSVLV(item));
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = qlsv.Tim(GetSVControl().mssv, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).mssv.CompareTo(obj1.ToString());
            });

            if (Validation())
            {
                if (sv != null) 
                    {
                        DialogResult dlg = MessageBox.Show("Mã sinh viên đã tồn tại, Bạn muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dlg == DialogResult.Yes)
                        {
                            UpdateSV(sv);
                            LoadSVToListView(qlsv.dssv);
                            context.SaveSV();
                            MessageBox.Show("Cập nhật sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                    }
                    else
                    {
                        qlsv.Them(GetSVControl());
                        LoadSVToListView(qlsv.dssv);
                        context.SaveSV();
                        MessageBox.Show("Thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void tsmXoa_Click(object sender, EventArgs e)
        {
            if(clbDKM.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            foreach (var item in clbDKM.CheckedItems)
            {
                dsMon.Remove(item as string);
            }

            clbDKM.Items.Clear();
            foreach (var monHoc in dsMon)
                clbDKM.Items.Add(monHoc, false);

        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.mssv.CompareTo(obj1);
        }

        private void cmsXoaSV_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem item;
            count = lvSV.Items.Count - 1;
            for (i = count; i > 0; i--)
            {
                item = lvSV.Items[i];
                if (item.Selected || item.Checked)
                    qlsv.Xoa(item.SubItems[0].Text, SoSanhTheoMa);
            }
            LoadSVToListView(qlsv.dssv);
            context.SaveSV();
        }

        private void cmsThem_Click(object sender, EventArgs e)
        {
            frmThemMH frm = new frmThemMH();
            var dialog = frm.ShowDialog();

            if(dialog == DialogResult.OK)
            {
                string tenMH = frm.tenMonHoc;
                if(dsMon.Exists(mh => mh == tenMH))
                {
                    MessageBox.Show("Môn học đã tồn tại");
                    return;
                }
                dsMon.Add(tenMH);
                clbDKM.Items.Clear();
                foreach (var monHoc in dsMon)
                    clbDKM.Items.Add(monHoc, false);
            }
        }
    }
}
