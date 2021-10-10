using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Model
{
    public class Lop
    {
        public string ClassName { get; set; }
        public List<SinhVien> listSinhVien;

        public Lop()
        {
            this.listSinhVien = new List<SinhVien>();
        }
    }
}
