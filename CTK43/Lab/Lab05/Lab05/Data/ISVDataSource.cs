using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05.Model;

namespace Lab05.Data
{
    public interface ISVDataSource
    {
        List<SinhVien> GetSV();
        void Save(List<SinhVien> sv);
    }
}
