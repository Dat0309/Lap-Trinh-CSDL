using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTruongHoc.Model;
using QuanLyTruongHoc.Data;

namespace QuanLyTruongHoc
{
    public class Context
    {
        private static Context singleObject;
        private List<Khoa> listKhoa;
        private IDataStorage dataStorage;

        private Context(IDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
        }

        public static Context getInstance(IDataStorage data)
        {
            if (singleObject == null)
                singleObject = new Context(data);
            return singleObject;
        }

        public List<Khoa> GetKhoa()
        {
            if (listKhoa == null) listKhoa = dataStorage.GetKhoa();
            return listKhoa;
        }
    }
}
