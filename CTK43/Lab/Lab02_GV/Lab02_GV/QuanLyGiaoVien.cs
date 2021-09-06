using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_GV
{
    public class QuanLyGiaoVien
    {
        public List<GiaoVien> dsGiaoVien;
        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }

        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index]; }
            set { dsGiaoVien[index] = value; }
        }
        public bool Them(GiaoVien giaoVien)
        {
            var isExists = dsGiaoVien.Exists(gv => gv.MaSo == giaoVien.MaSo);
            if (isExists) return false;
            dsGiaoVien.Add(giaoVien);
            return true;
        }

        public GiaoVien Tim(string value, KieuTim kieu)
        {
            GiaoVien giaoVien = null;

            switch (kieu)
            {
                case KieuTim.TheoMa:
                    giaoVien = dsGiaoVien.Find(gv => gv.MaSo == value);
                    break;
                case KieuTim.TheoHoTen:
                    giaoVien = dsGiaoVien.Find(gv => gv.HoTen.ToLower() == value.ToLower());
                    break;
                case KieuTim.TheoSDT:
                    giaoVien = dsGiaoVien.Find(gv => gv.SoDT == value);
                    break;
                default:
                    break;
            }
            return giaoVien;
        }

        public void Xoa(GiaoVien gv)
        {
            var isExists = dsGiaoVien.Find(x => x.MaSo == gv.MaSo);
            if (isExists != null) dsGiaoVien.Remove(gv);
        }
    }
}
