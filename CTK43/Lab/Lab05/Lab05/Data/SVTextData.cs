using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05.Model;
using System.IO;

namespace Lab05.Data
{
    public class SVTextData : ISVDataSource
    {
        private string fileName;

        public SVTextData(string fileName)
        {
            this.fileName = fileName;
        }

        public List<SinhVien> GetSV()
        {
            List<SinhVien> sinhViens = new List<SinhVien>();
            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
                {
                    string line;
                    while((line = reader.ReadLine())!= null)
                    {
                        var sinhvien = ParseSV(line);
                        sinhViens.Add(sinhvien);
                    }
                }
            }
            return sinhViens;
        }

        public void Save(List<SinhVien> sv)
        {
            using (var writer = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)))
            {
                foreach (var item in sv)
                {
                    var line = SaveFormat(item);
                    writer.WriteLine(line);
                }
            }
        }

        private SinhVien ParseSV(string line)
        {
            var parts = line.Split('*');
            return new SinhVien()
            {
                mssv = parts[0],
                ho = parts[1],
                ten = parts[2],
                ngaySinh = DateTime.Parse(parts[3]),
                lop = parts[4],
                cmnd = parts[5],
                sdt = parts[6],
                diaChi = parts[7],
                gioiTinh = (int.Parse(parts[8]) == 1 ? true : false),
                monHoc = addMonHoc(parts[9])
            };
        }
        private string SaveFormat(SinhVien sinhvien)
        {
            string dsMonHoc = string.Join(",", sinhvien.monHoc);
            if (string.IsNullOrWhiteSpace(dsMonHoc))
                dsMonHoc = "null";
            return string.Format("{0}*{1}*{2}*{3}*{4}*{5}*{6}*{7}*{8}*{9}",
                sinhvien.mssv, 
                sinhvien.ho,
                sinhvien.ten, 
                sinhvien.ngaySinh.ToShortDateString(),
                sinhvien.lop,
                sinhvien.cmnd,
                sinhvien.sdt, 
                sinhvien.diaChi,
                (sinhvien.gioiTinh == true?"1":"0"),
                dsMonHoc);
        }
        private List<string> addMonHoc(string line)
        {
            List<string> mh = new List<string>();
            string[] chuyennganh = line.Split(',');
            foreach (string item in chuyennganh)
            {
                mh.Add(item);
            }
            return mh;
        }
    }
}
