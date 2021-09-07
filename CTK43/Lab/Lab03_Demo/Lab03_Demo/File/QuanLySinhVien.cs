using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab03_Demo.File
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public List<SinhVien> dsSinhVien;

        public QuanLySinhVien()
        {
            this.dsSinhVien = new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            this.dsSinhVien.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return dsSinhVien[index]; }
            set { dsSinhVien[index] = value; }
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i = dsSinhVien.Count - 1;
            for (; i > -0; i--)
                if (ss(obj, this[i]) == 0)
                    this.dsSinhVien.RemoveAt(i);
        }

        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svResult = null;
            foreach (SinhVien sv in dsSinhVien)
            {
                if(ss(obj, sv) == 0)
                {
                    svResult = sv;
                    break;
                }
            }
            return svResult;
        }

        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.dsSinhVien.Count - 1;
            for(i = 0; i<count; i++)
                if(ss(obj, this[i]) == 0)
                {
                    this[i] = svSua;
                    kq = true;
                    break;
                }
            return kq;
        }

        public void DocTuFile()
        {
            string fileName = "DanhSachSV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.NgaySinh = DateTime.Parse(s[2]);
                sv.DiaChi = s[3];
                sv.Lop = s[4];
                sv.Hinh = s[5];
                bool gt = (s[6] == "1" ? true : false);
                sv.GioiTinh = gt;
                string[] chuyenNganh = s[7].Split(',');
                foreach (string c in chuyenNganh)
                {
                    sv.ChuyenNganh.Add(c);
                }
                this.Them(sv);
            }
        }
    }
}
