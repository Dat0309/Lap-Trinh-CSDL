using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab04_Aplication.Model;
using System.IO;

namespace Lab04_Aplication.Data
{
    class DataSource : IDataSource
    {
        private string fileName;

        public DataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public List<SinhVien> GetSV()
        {
            List<SinhVien> sv = new List<SinhVien>();
            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var sinhvien = ParseSV(line);
                        sv.Add(sinhvien);
                    }
                }
            }
            return sv;
        }

        public void Save(List<SinhVien> sv)
        {
            using(var writer = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)))
            {
                foreach(var item in sv)
                {
                    var line = SVFormat(item);
                    writer.WriteLine(line);
                }
            }
        }

        private SinhVien ParseSV(string line)
        {
            var parts = line.Split('^');

            return new SinhVien()
            {
                mssv = parts[0],
                hoTen = parts[1],
                ngaySinh = DateTime.Parse(parts[2]),
                diaChi = parts[3],
                lop = parts[4],
                hinh = parts[5],
                phai = (int.Parse(parts[6]) == 1 ? true:false),
                sdt = parts[7],
                email = parts[8],
            };
        }

        private string SVFormat(SinhVien sinhvien)
        {
            return string.Format("{0}^{1}^{2}^{3}^{4}^{5}^{6}^{7}^{8}",
                sinhvien.mssv, sinhvien.hoTen,sinhvien.ngaySinh,sinhvien.diaChi,sinhvien.lop,sinhvien.hinh,
                (sinhvien.phai == true ? 1:0), sinhvien.sdt, sinhvien.email);
        }
    }
}
