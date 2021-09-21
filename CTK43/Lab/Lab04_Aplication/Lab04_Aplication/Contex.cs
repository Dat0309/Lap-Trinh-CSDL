using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab04_Aplication.Model;
using Lab04_Aplication.Data;

namespace Lab04_Aplication
{
    public class Contex
    {
        private List<SinhVien> sv;
        private IDataSource dataSource;

        public Contex(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public List<SinhVien> GetSV()
        {
            if (sv == null)
                sv = dataSource.GetSV();
            return sv;
        }
        public void SaveSV()
        {
            dataSource.Save(sv);
        }
    }
}
