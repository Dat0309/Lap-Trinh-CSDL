using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05.Model;
using System.IO;
using System.Xml;

namespace Lab05.Data
{
    public class SVXMLData : ISVDataSource
    {
        XmlDocument docXml = new XmlDocument();
        XmlElement root;
        public string fileName;

        public SVXMLData(string fileName)
        {
            this.fileName = fileName;
            docXml.Load(fileName);
            root = docXml.DocumentElement;
        }


        public List<SinhVien> GetSV()
        {
            List<SinhVien> dssv = new List<SinhVien>();
            if (!File.Exists(fileName))
            {
                FileStream fs = File.Create(fileName);
                fs.Close();
            }
            XmlNodeList ds = root.SelectNodes("SinhVien");
            foreach (XmlNode item in ds)
            {
                SinhVien sv = new SinhVien();
                sv.mssv = item.SelectSingleNode("mssv").InnerText;
                sv.ho = item.SelectSingleNode("ho").InnerText;
                sv.ten = item.SelectSingleNode("ten").InnerText;
                sv.ngaySinh = DateTime.Parse(item.SelectSingleNode("ngaySinh").InnerText);
                sv.lop = item.SelectSingleNode("lop").InnerText;
                sv.cmnd = item.SelectSingleNode("cmnd").InnerText;
                sv.sdt = item.SelectSingleNode("sdt").InnerText;
                sv.diaChi = item.SelectSingleNode("diaChi").InnerText;
                sv.gioiTinh = (int.Parse(item.SelectSingleNode("gioiTinh").InnerText) == 1? true: false);
                sv.monHoc = addMonHoc(item.SelectSingleNode("monHoc").InnerText);

                dssv.Add(sv);
            }
            return dssv;
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

        public void Save(List<SinhVien> dssv)
        {
            root.RemoveAll();
            foreach  (SinhVien item in dssv)
            {
                string dsMonHoc = string.Join(",", item.monHoc);
                if (string.IsNullOrWhiteSpace(dsMonHoc))
                    dsMonHoc = "null";
                XmlElement sv = docXml.CreateElement("SinhVien");

                XmlElement mssv = docXml.CreateElement("mssv");
                mssv.InnerText = item.mssv;
                sv.AppendChild(mssv);

                XmlElement ho = docXml.CreateElement("ho");
                ho.InnerText = item.ho;
                sv.AppendChild(ho);

                XmlElement ten = docXml.CreateElement("ten");
                ten.InnerText = item.ten;
                sv.AppendChild(ten);

                XmlElement ngaySinh = docXml.CreateElement("ngaySinh");
                ngaySinh.InnerText = item.ngaySinh.ToShortDateString();
                sv.AppendChild(ngaySinh);

                XmlElement lop = docXml.CreateElement("lop");
                lop.InnerText = item.lop;
                sv.AppendChild(lop);

                XmlElement cmnd = docXml.CreateElement("cmnd");
                cmnd.InnerText = item.cmnd;
                sv.AppendChild(cmnd);

                XmlElement sdt = docXml.CreateElement("sdt");
                sdt.InnerText = item.sdt;
                sv.AppendChild(sdt);

                XmlElement diaChi = docXml.CreateElement("diaChi");
                diaChi.InnerText = item.diaChi;
                sv.AppendChild(diaChi);

                XmlElement gioiTinh = docXml.CreateElement("gioiTinh");
                gioiTinh.InnerText = (item.gioiTinh == true? "1": "0");
                sv.AppendChild(gioiTinh);

                XmlElement dsMH = docXml.CreateElement("monHoc");
                dsMH.InnerText = dsMonHoc;
                sv.AppendChild(dsMH);

                root.AppendChild(sv);
                docXml.Save(fileName);
            }
            
        }
    }
}
