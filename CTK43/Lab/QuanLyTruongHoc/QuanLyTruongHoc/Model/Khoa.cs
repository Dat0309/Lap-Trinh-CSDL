using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Model
{
    public class Khoa
    {
        public string Name { get; set; }
        public List<Lop> listLop;

        public Khoa()
        {
            this.listLop = new List<Lop>();
        }
    }
}
