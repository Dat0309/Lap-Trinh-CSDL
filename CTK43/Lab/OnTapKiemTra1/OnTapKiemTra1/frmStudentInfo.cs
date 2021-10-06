using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnTapKiemTra1.IO;
using OnTapKiemTra1.Model;

namespace OnTapKiemTra1
{
    public partial class frmStudentInfo : Form
    {
        private QLSV qlsv;
        private NewRepo newRepo;
        public string tenKhoa;
        public string tenLop;
        public SinhVien sv;
        public frmStudentInfo(QLSV qlsv, NewRepo newRepo)
        {
            InitializeComponent();
            this.qlsv = qlsv;
            this.newRepo = newRepo;
        }

        #region Cac ham xu ly
        private void SetValueCbb(List<Khoa> dsKhoa)
        {
            cbbKhoa.Items.Clear();
            cbbLop.Items.Clear();
            foreach (var k in dsKhoa)
            {
                cbbKhoa.Items.Add(k.Name);
                foreach (var l in k.Lop)
                {
                    cbbLop.Items.Add(l.Name);
                }
            }
        }

        private SinhVien GetSVInControl()
        {
            SinhVien sv = new SinhVien();
            sv.mssv = mtbMSSV.Text;
            sv.ho = txtHoten.Text;
            sv.ten = txtTen.Text;
            sv.lop = cbbLop.Text;
            sv.khoa = cbbKhoa.Text;
            sv.gioiTinh = (rbNam.Checked == true ? true : false);
            sv.ngaySinh = dtpNgaySinh.Value;
            sv.sdt = mtbSDT.Text;

            return sv;
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(mtbMSSV.Text)) return false;
            else if (string.IsNullOrEmpty(txtHoten.Text)) return false;
            else if (string.IsNullOrEmpty(txtTen.Text)) return false;
            else if (string.IsNullOrEmpty(cbbLop.Text)) return false;
            else if (string.IsNullOrEmpty(cbbKhoa.Text)) return false;
            else if (rbNam.Checked == false && rbNu.Checked == false) return false;
            else if (string.IsNullOrEmpty(mtbSDT.Text)) return false;
            return true;
        }
        private void SetSVInControl()
        {
            if(sv != null)
            {
                mtbMSSV.Enabled = false;
                mtbMSSV.Text = sv.mssv;
                txtHoten.Text = sv.ho;
                txtTen.Text = sv.ten;
                rbNam.Checked = (sv.gioiTinh == true ? true : false);
                rbNu.Checked = (sv.gioiTinh == false ? true : false);
                dtpNgaySinh.Text = DateTime.Now.ToShortDateString();
                cbbKhoa.Text = sv.khoa;
                cbbLop.Text = sv.lop;
                mtbSDT.Text = sv.sdt;
            }
        }
        #endregion

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            SetValueCbb(newRepo.GetKhoa());
            cbbKhoa.Text = tenKhoa;
            cbbLop.Text = tenLop;
            SetSVInControl();
        }

        private void cbbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string khoa = cbbKhoa.Text.Trim();
            cbbLop.Items.Clear();
            foreach (var item in newRepo.GetKhoa())
            {
                if (khoa.CompareTo(item.Name) == 0)
                {
                    foreach (var l in item.Lop)
                    {
                        cbbLop.Items.Add(l.Name);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = qlsv.Tim(GetSVInControl().mssv, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).mssv.CompareTo(obj1.ToString());
            });

            if (Validation())
            {
                if (sv != null)
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn cập nhật không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlg == DialogResult.Yes)
                    {
                        bool isUpdate = qlsv.Sua(GetSVInControl(), GetSVInControl().mssv, delegate (object obj1, object obj2)
                        {
                            return (obj2 as SinhVien).mssv.CompareTo(obj1.ToString());
                        });

                        if (isUpdate)
                        {
                            //MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            //this.Close();
                            DialogResult = DialogResult.Yes;
                            this.Close();
                        }
                    }
                }
                else
                {
                    qlsv.Them(GetSVInControl());
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
