using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTruongHoc.Model;
using System.IO;

namespace QuanLyTruongHoc.Data
{
    public class TextDataStorage : IDataStorage
    {
        private string fileName;

        public TextDataStorage(string fileName)
        {
            this.fileName = fileName;
        }

        public List<Khoa> GetKhoa()
        {
            List<Khoa> listKhoa = new List<Khoa>();
            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read)))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var khoa = ParserKhoa(line);
                        listKhoa.Add(khoa);
                    }
                }
            }
            else
            {
                File.Create(fileName);
            }
            return listKhoa;
        }

        private Khoa ParserKhoa(string line)
        {
            List<Lop> classs = new List<Lop>();
            classs.Add(ParserLop(line));
            var parts = line.Split('\t');
            return new Khoa()
            {
                Name = parts[4],
                listLop = classs
            };

        }
        private Lop ParserLop(string line)
        {
            List<SinhVien> sinhviens = new List<SinhVien>();
            sinhviens.Add(ParserSV(line));
            var parts = line.Split('\t');
            return new Lop()
            {
                ClassName = parts[3],
                listSinhVien = sinhviens
            };
        }
        private SinhVien ParserSV(string line)
        {
            var parts = line.Split('\t');
            return new SinhVien()
            {
                StudentID = parts[0],
                FirstName = parts[1],
                LastName = parts[2],
                BirthDay = DateTime.MinValue,
                Gender = true,
                PhoneNumber = "",
                Address = ""
            };
        }
    }
}

