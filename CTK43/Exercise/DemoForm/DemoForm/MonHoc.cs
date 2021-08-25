using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public class MonHoc
    {
        public string MaHP { get; set; }
        public string TenHP { get; set; }
        public int LoaiHP { get; set; }
        public int STC { get; set; }
        public int Nam { get; set; }

        public MonHoc() { }

        public MonHoc(string maHP, string tenHP, int stc , int loaiHP, int nam)
        {
            this.MaHP = maHP;
            this.TenHP = tenHP;
            this.LoaiHP = loaiHP;
            this.STC = stc;
            this.Nam = nam;
        }

    }
}
