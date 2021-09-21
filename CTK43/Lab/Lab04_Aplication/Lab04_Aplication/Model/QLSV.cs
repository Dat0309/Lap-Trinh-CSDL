using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab04_Aplication.Model
{
    public class QLSV
    {
        public delegate int SoSanh(object sv1, object sv2);
        public List<SinhVien> ds;

        public QLSV()
        {
            this.ds = new List<SinhVien>();
        }

        public void Them(SinhVien sv)
        {
            ds.Add(sv);
        }

        public SinhVien this[int index]
        {
            get { return ds[index]; }
            set { ds[index] = value; }
        }

        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien sv = null;
            foreach (SinhVien item in ds)
            {
                if (ss(obj, item) == 0)
                {
                    sv = item;
                    break;
                }
            }
            return sv;
        }
        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = ds.Count - 1;
            for(i = 0; i < count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svSua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }

        public void DocTuFile()
        {
            string fileName = "Data\\DSSV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('^');
                sv = new SinhVien();
                sv.mssv = s[0];
                sv.hoTen = s[1];
                sv.ngaySinh = DateTime.Parse(s[2]);
                sv.diaChi = s[3];
                sv.lop = s[4];
                sv.hinh = s[5];
                sv.phai = (s[6] == "1" ? true : false);
                sv.sdt = s[7];
                sv.email = s[8];
                Them(sv);
            }
        }
        public void Xoa(object obj, SoSanh ss)
        {
            int i = ds.Count - 1;
            for (; i > 0; i--)
                if (ss(obj, this[i]) == 0)
                    ds.RemoveAt(i);
        }
    }
}
