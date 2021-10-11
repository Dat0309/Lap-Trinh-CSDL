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

        //public void Save(List<SinhVien> sv)
        //{
        //    using(var writer = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite)))
        //    {
        //        foreach (var item in sv)
        //        {
        //        }
        //    }
        //}

        private SinhVien ParseSV(string line)
        {
            var parts = line.Split('\t');
            return new SinhVien()
            {
                StudentId = parts[0],
                FirstName = parts[1],
                LastName = parts[2],
                ClassName = parts[3],
                FacultyName = parts[4],
                Gender = true,
                DateOfBirth = DateTime.MinValue,
                PhoneNumber = "",
                Address = ""
            };
        }

    }
}
