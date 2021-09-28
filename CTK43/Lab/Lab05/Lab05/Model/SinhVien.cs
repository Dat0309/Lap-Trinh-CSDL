using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.Model
{
    public class SinhVien
    {
        public string mssv { get; set; }
        public string ho { get; set; }
        public string ten { get; set; }
        public DateTime ngaySinh { get; set; }
        public string lop { get; set; }
        public string cmnd { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; }
        public bool gioiTinh { get; set; }
        public List<string> monHoc { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(string mssv, string ho, string ten, DateTime ngaySinh, string lop, string cmnd, string sdt, string diaChi, bool gioiTinh, List<string> monHoc)
        {
            this.mssv = mssv;
            this.ho = ho;
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.lop = lop;
            this.cmnd = cmnd;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.monHoc = monHoc;
        }
    }
}
