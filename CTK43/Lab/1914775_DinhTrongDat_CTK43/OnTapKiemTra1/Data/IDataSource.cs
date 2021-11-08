using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKiemTra1.Data
{
    public interface IDataSource
    {
        List<SinhVien> GetSV();
    }
}
