using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab04_Aplication.Model;

namespace Lab04_Aplication.Data
{
    public interface IDataSource
    {
        List<SinhVien> GetSV();
        void Save(List<SinhVien> sv);
    }
}
