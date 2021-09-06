using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_GV
{
    public class MonHoc
    {
        public int Id { get; set; }
        public string TenMH { get; set; }
        public int SoTC { get; set; }
        public MonHoc() { }
        public MonHoc(string ten)
        {
            TenMH = ten;
        }
        public MonHoc(int id, string ten, int tc)
        {
            Id = id;
            TenMH = ten;
            SoTC = tc;
        }
        public override string ToString()
        {
            return TenMH;
        }
    }
}
