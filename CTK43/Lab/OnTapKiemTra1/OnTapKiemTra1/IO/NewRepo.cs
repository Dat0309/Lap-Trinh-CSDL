using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnTapKiemTra1.Model;

namespace OnTapKiemTra1.IO
{
    public class NewRepo : INewRepo
    {
        private static NewRepo singleObject;
        private QLSV qlsv;

        private NewRepo(QLSV qlsv)
        {
            this.qlsv = qlsv;
        }

        public static NewRepo getInstance(QLSV qlsv)
        {
            if (singleObject == null)
                singleObject = new NewRepo(qlsv);
            return singleObject;
        }
        public List<Khoa> GetKhoa()
        {
            List<Khoa> dsKhoa = new List<Khoa>();
            foreach (var item in GetDSKhoa(qlsv.dssv))
            {
                List<Lop> dsLop = new List<Lop>();
                foreach (var l in GetDSLop(item))
                    dsLop.Add(new Lop(l));
                dsKhoa.Add(new Khoa(item, dsLop));
            }
            return dsKhoa;
        }

        private List<string> GetDSKhoa(List<SinhVien> dssv)
        {
            List<string> tenKhoa = new List<string>();
            foreach (var item in dssv)
            {
                if (!tenKhoa.Contains(item.FacultyName))
                    tenKhoa.Add(item.FacultyName);
            }
            return tenKhoa;
        }
        private List<string> GetDSLop(string tenKhoa)
        {
            List<string> dsLop = new List<string>();
            foreach (var item in qlsv.dssv)
                if (item.FacultyName.CompareTo(tenKhoa) == 0)
                    if(!dsLop.Contains(item.ClassName))
                        dsLop.Add(item.ClassName);
            return dsLop;
        }

        //private Khoa ParserKhoa(string name)
        //{
        //    return new Khoa()
        //    {
        //        Name = name.Trim()
        //    };
        //}
        //private Lop ParserLop(string name)
        //{
        //    return new Lop()
        //    {
        //        Name = name.Trim()
        //    };
        //}
    }
}
