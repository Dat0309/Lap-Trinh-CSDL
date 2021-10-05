using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra1.Model
{
    public class Khoa
    {
        public string Name { get; set; }
        public List<Lop> Lop { get; set; }

        public Khoa(string name, List<Lop> lop)
        {
            this.Name = name;
            this.Lop = lop;
        }
        public Khoa()
        {
            this.Lop = new List<Lop>();
        }

    }
}
