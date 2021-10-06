using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra1
{
    public class SinhVien
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string ClassName { get; set; }
        public string FacultyName { get; set; }
        public string Address { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string mssv, string ho, string ten, bool gioiTinh, DateTime ngaySinh, string sdt, string lop, string khoa, string diaChi)
        {
            this.StudentId = mssv;
            this.FirstName = ho;
            this.LastName = ten;
            this.Gender = gioiTinh;
            this.DateOfBirth = ngaySinh;
            this.PhoneNumber = sdt;
            this.ClassName = lop;
            this.FacultyName = khoa;
            this.Address = diaChi;
        }
    }
}
