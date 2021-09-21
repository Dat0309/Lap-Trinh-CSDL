using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Aplication.Model
{
    public class SinhVien
    {
        public string mssv { get; set; }
        public string hoTen { get; set; }
        public bool phai { get; set; }
        public DateTime ngaySinh { get; set; }
        public string lop { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string diaChi { get; set; }
        public string hinh { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string mssv, string hoTen, bool phai, DateTime ngaySinh, string lop, string sdt, string email, string diaChi, string hinh)
        {
            this.mssv = mssv;
            this.hoTen = hoTen;
            this.phai = phai;
            this.ngaySinh = ngaySinh;
            this.lop = lop;
            this.sdt = sdt;
            this.email = email;
            this.diaChi = diaChi;
            this.hinh = hinh;
        }
    }
}
