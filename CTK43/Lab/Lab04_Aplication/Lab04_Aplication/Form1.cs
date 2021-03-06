using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_Aplication.Model;
using System.Text.RegularExpressions;

namespace Lab04_Aplication
{
    public partial class Form1 : Form
    {
        public Contex context;
        private List<SinhVien> students;
        QLSV qlsv;
        public Form1(Contex context)
        {
            InitializeComponent();
            this.context = context;
            students = context.GetSV();
        }

        #region các hàm xử lý chức năng
        // Thêm Sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.mssv);
            item.SubItems.Add(sv.hoTen);
            item.SubItems.Add((sv.phai == true ? "Nam" : "Nu"));
            item.SubItems.Add(sv.ngaySinh.ToShortDateString());
            item.SubItems.Add(sv.lop);
            item.SubItems.Add(sv.sdt);
            item.SubItems.Add(sv.email);
            item.SubItems.Add(sv.diaChi);
            item.SubItems.Add(sv.hinh);
            lvSV.Items.Add(item);
        }

        //Hiển thị danh sách sinh viên ra ListView
        private void LoadSVToListView(List<SinhVien> danhsach)
        {
            lvSV.Items.Clear();
            foreach (SinhVien sv in danhsach)
                ThemSV(sv);
        }
        //Lấy thông tin sinh viên khi chọn
        private SinhVien GetSinhVienLV(ListViewItem item)
        {
            SinhVien sv = new SinhVien();
            sv.mssv = item.SubItems[0].Text;
            sv.hoTen = item.SubItems[1].Text;
            sv.phai = (item.SubItems[2].Text == "Nam" ? true : false);
            sv.ngaySinh = DateTime.Parse(item.SubItems[3].Text);
            sv.lop = item.SubItems[4].Text;
            sv.sdt = item.SubItems[5].Text;
            sv.email = item.SubItems[6].Text;
            sv.diaChi = item.SubItems[7].Text;
            sv.hinh = item.SubItems[8].Text;

            return sv;
        }
        //Thiết lập thông tin sinh viên lên control khi chọn
        private void ThietLapConTrol(SinhVien sv)
        {
            mtbMSSV.Text = sv.mssv;
            txtHoTen.Text = sv.hoTen;
            dpkNgaySinh.Value = sv.ngaySinh;
            txtDiaChi.Text = sv.diaChi;
            cbbLop.Text = sv.lop;
            txtHinh.Text = sv.hinh;
            rbNam.Checked = (sv.phai == true ? true : false);
            rbNu.Checked = (sv.phai == false ? true : false);
            mtbSdt.Text = sv.sdt;
            txtEmail.Text = sv.email;
            try
            {
                pbHinhAnh.Load(sv.hinh);
            }
            catch { }
        }
        //Thêm sinh viên từ control
        private SinhVien GetSVControl()
        {
            SinhVien sv = new SinhVien();
            sv.mssv = mtbMSSV.Text;
            sv.hoTen = txtHoTen.Text;
            sv.ngaySinh = dpkNgaySinh.Value;
            sv.diaChi = txtDiaChi.Text;
            sv.lop = cbbLop.Text;
            sv.hinh = txtHinh.Text;
            sv.phai = (rbNam.Checked == true ? true : false);
            sv.sdt = mtbSdt.Text;
            sv.email = txtEmail.Text;
            sv.hinh = txtHinh.Text;
            return sv;
        }
        private SinhVien UpDateSV(SinhVien sv)
        {
            SinhVien svUpdate = GetSVControl();
            sv.mssv = svUpdate.mssv;
            sv.hoTen = svUpdate.hoTen;
            sv.ngaySinh = svUpdate.ngaySinh;
            sv.diaChi = svUpdate.diaChi;
            sv.lop = svUpdate.lop;
            sv.hinh = svUpdate.hinh;
            sv.phai = svUpdate.phai;
            sv.sdt = svUpdate.sdt;
            sv.email = svUpdate.email;
            sv.hinh = svUpdate.hinh;
            return sv;
        }
        #endregion

        private void btnChoHinh_Click(object sender, EventArgs e)
        {
            DialogResult dlg = ofdPicture.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                var fileName = ofdPicture.FileName;
                txtHinh.Text = fileName;
                pbHinhAnh.Load(fileName);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            mtbMSSV.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtHinh.Text = "";
            dpkNgaySinh.Value = DateTime.Now;
            cbbLop.Text = cbbLop.Items[0].ToString();
            rbNam.Checked = true;
            mtbSdt.Text = "";
            pbHinhAnh.ImageLocation = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = qlsv.Tim(GetSVControl().mssv, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).mssv.CompareTo(obj1.ToString());
            });

            if (validation() && validationEmail())
            {
                if (sv != null)
                {
                    DialogResult dlg = MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlg == DialogResult.Yes)
                    {
                        UpDateSV(sv);
                        LoadSVToListView(qlsv.ds);
                    }
                }
                else
                {
                    qlsv.Them(GetSVControl());
                    LoadSVToListView(qlsv.ds);
                }
            }
            else if(!validation())
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ các thông tin!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Nhập sai định dạng Email, Xin mời nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool validation()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text)) return false;
            else if (string.IsNullOrEmpty(txtDiaChi.Text)) return false;
            else if (string.IsNullOrEmpty(txtEmail.Text)) return false;
            else if (string.IsNullOrEmpty(mtbMSSV.Text)) return false;
            else if (string.IsNullOrEmpty(mtbSdt.Text)) return false;
            else if (string.IsNullOrEmpty(cbbLop.Text)) return false;
            else return true;
        }

        private bool validationEmail()
        {
            Regex reg = new Regex(@"\S+@\S+\.\S+");
            if (!reg.IsMatch(txtEmail.Text)) return false;
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qlsv = new QLSV(context);
            //qlsv.DocTuFile();
            LoadSVToListView(qlsv.ds);
        }

        private void lvSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem item = lvSV.SelectedItems[0];
                ThietLapConTrol(GetSinhVienLV(item));
            }
        }

        private void tsmXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem item;
            count = lvSV.Items.Count - 1;
            for(i=count; i >= 0; i--)
            {
                item = lvSV.Items[i];
                if (item.Selected)
                    qlsv.Xoa(item.SubItems[0].Text, SoSanhTheoMa);
            }
            LoadSVToListView(qlsv.ds);
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.mssv.CompareTo(obj1);
        }

        private void tsmLoad_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có chắc không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlg == DialogResult.Yes)
            {
                qlsv.ds.Clear();
                qlsv.DocTuFile();
                LoadSVToListView(qlsv.ds);
            }
            return;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn muốn lưu danh sách lại hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlg == DialogResult.Yes)
                context.SaveSV();
            return;
        }
    }
}
