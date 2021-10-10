using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTruongHoc.Model;

namespace QuanLyTruongHoc.Data
{
    public interface IDataStorage
    {
        List<Khoa> GetKhoa();
    }
}
