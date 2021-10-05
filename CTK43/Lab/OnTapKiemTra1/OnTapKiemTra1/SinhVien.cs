using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra1
{
    public class SinhVien
    {
        public string mssv { get; set; }
        public string ho { get; set; }
        public string ten { get; set; }
        public bool gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string sdt { get; set; }
        public string lop { get; set; }
        public string khoa { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string mssv, string ho, string ten, bool gioiTinh, DateTime ngaySinh, string sdt, string lop, string khoa)
        {
            this.mssv = mssv;
            this.ho = ho;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.sdt = sdt;
            this.lop = lop;
            this.khoa = khoa;
        }
    }
}
