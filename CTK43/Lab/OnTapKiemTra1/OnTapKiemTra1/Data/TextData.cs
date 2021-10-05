using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnTapKiemTra1.Data
{
    public class TextData : IDataSource
    {
        private string fileName;

        public TextData(string fileName)
        {
            this.fileName = fileName;
        }

        public List<SinhVien> GetSV()
        {
            List<SinhVien> listSV = new List<SinhVien>();
            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        var sinhvien = ParseSV(line);
                        listSV.Add(sinhvien);
                    }
                }
            }
            return listSV;
        }

        public void Save(List<SinhVien> sv)
        {
            using(var writer = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)))
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
            var parts = line.Split('\t');
            return new SinhVien()
            {
                mssv = parts[0],
                ho = parts[1],
                ten = parts[2],
                lop = parts[3],
                khoa = parts[4],
                gioiTinh = true,
                ngaySinh = DateTime.MinValue,
                sdt = ""
            };
        }

        private string SaveFormat(SinhVien sv)
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",
                sv.mssv,
                sv.ho,
                sv.ten,
                sv.lop,
                sv.khoa,
                (sv.gioiTinh == true ? "1" : "0"),
                sv.ngaySinh,
                sv.sdt);
        }
    }
}
