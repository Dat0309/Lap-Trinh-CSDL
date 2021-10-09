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
            sv.StudentId = mtbMSSV.Text;
            sv.FirstName = txtHoten.Text;
            sv.LastName = txtTen.Text;
            sv.ClassName = cbbLop.Text;
            sv.FacultyName = cbbKhoa.Text;
            sv.Gender = (rbNam.Checked == true ? true : false);
            sv.DateOfBirth = dtpNgaySinh.Value;
            sv.PhoneNumber = mtbSDT.Text;
            sv.Address = txtDiaChi.Text;

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
            else if (string.IsNullOrEmpty(txtDiaChi.Text)) return false;
            return true;
        }
        private void SetSVInControl()
        {
            if(sv != null)
            {
                mtbMSSV.Enabled = false;
                mtbMSSV.Text = sv.StudentId;
                txtHoten.Text = sv.FirstName;
                txtTen.Text = sv.LastName;
                rbNam.Checked = (sv.Gender == true ? true : false);
                rbNu.Checked = (sv.Gender == false ? true : false);
                dtpNgaySinh.Text = DateTime.Now.ToShortDateString();
                cbbKhoa.Text = sv.FacultyName;
                cbbLop.Text = sv.ClassName;
                mtbSDT.Text = sv.PhoneNumber;
                txtDiaChi.Text = sv.Address;
            }
        }

        private SinhVien UpdateSV(SinhVien sv)
        {
            SinhVien svUpdate = GetSVInControl();
            sv.FirstName = svUpdate.FirstName;
            sv.LastName = svUpdate.LastName;
            sv.DateOfBirth = svUpdate.DateOfBirth;
            sv.ClassName = svUpdate.ClassName;
            sv.FacultyName = svUpdate.FacultyName;
            sv.PhoneNumber = svUpdate.PhoneNumber;
            sv.Gender = svUpdate.Gender;
            sv.Address = svUpdate.Address;
            return sv;
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
            SinhVien sv = qlsv.Tim(GetSVInControl().StudentId, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).StudentId.CompareTo(obj1.ToString());
            });

            if (Validation())
            {
                if (sv != null)
                {
                    DialogResult dlg = MessageBox.Show("Bạn có chắc muốn cập nhật không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlg == DialogResult.Yes)
                    {
                        UpdateSV(sv);
                        DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                }
                else
                {
                    this.tenLop = GetSVInControl().ClassName;
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
