using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05.Model;
using System.IO;

namespace Lab05.Data
{
    public class SVXMLData : ISVDataSource
    {
        public string fileName;

        public SVXMLData(string fileName)
        {
            this.fileName = fileName;
        }

        public List<SinhVien> GetSV()
        {
        }

        public void Save(List<SinhVien> sv)
        {
            throw new NotImplementedException();
        }
    }
}
