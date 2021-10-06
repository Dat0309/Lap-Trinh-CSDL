using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra1
{
    public class QLSV
    {
        Context context;
        public delegate int SoSanh(object sv1, Object sv2);
        public List<SinhVien> dssv;

        public QLSV(Context context)
        {
            this.context = context;
            dssv = context.GetSV();
        }

        public SinhVien this[int index]
        {
            get { return dssv[index]; }
            set { dssv[index] = value; }
        }

        public void Them(SinhVien sv)
        {
            dssv.Add(sv);
        }

        public void Xoa(object obj, SoSanh ss)
        {
            int i = dssv.Count - 1;
            for (; i > 0; i--)
                if (ss(obj, this[i]) == 0)
                    dssv.RemoveAt(i);
        }
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien sv = null;
            foreach (SinhVien item in dssv)
            {
                if (ss(obj, item) == 0)
                {
                    sv = item;
                    break;
                }
            }
            return sv;
        }
        public List<SinhVien> DSTim(object obj, SoSanh ss)
        {
            List<SinhVien> dskq = new List<SinhVien>();
            foreach (SinhVien item in dssv)
            {
                if (ss(obj, item) == 0)
                {
                    dskq.Add(item);
                }
            }
            return dskq;
        }

        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = dssv.Count - 1;
            for (i = 0; i < count; i++)
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
    }
}
