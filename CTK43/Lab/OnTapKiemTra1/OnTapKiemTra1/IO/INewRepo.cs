using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnTapKiemTra1.Model;

namespace OnTapKiemTra1.IO
{
    public interface INewRepo
    {
        List<Khoa> GetKhoa();
    }
}
