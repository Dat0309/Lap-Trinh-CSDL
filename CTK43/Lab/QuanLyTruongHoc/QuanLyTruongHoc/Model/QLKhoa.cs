using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTruongHoc.Model
{
    public class QLKhoa
    {
        Context context;
        public delegate int SoSanh(object sv1, object sv2);
        public List<Khoa> dsk;

        public QLKhoa(Context context)
        {
            this.context = context;
            dsk = context.GetKhoa();
        }
        public Khoa this[int index]
        {
            get { return dsk[index]; }
            set { dsk[index] = value; }
        }
        public void Them(Khoa khoa)
        {
            dsk.Add(khoa);
        }
        public void Xoa(object obj, SoSanh ss)
        {
            int i = dsk.Count - 1;
            for (; i > 0; i--)
                if (ss(obj, this[i]) == 0)
                    dsk.RemoveAt(i);
        }
        public Khoa Tim(object obj, SoSanh ss)
        {
            Khoa k = null;
            foreach (Khoa item in dsk)
            {
                if (ss(obj, item) == 0)
                {
                    k = item;
                    break;
                }
            }
            return k;
        }
        public List<Khoa> DSTim(object obj, SoSanh ss)
        {
            List<Khoa> dskq = new List<Khoa>();
            foreach (Khoa item in dsk)
            {
                if (ss(obj, item) == 0)
                {
                    dskq.Add(item);
                }
            }
            return dskq;
        }
    }
}
