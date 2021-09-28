using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05.Model;
using Lab05.Data;

namespace Lab05
{
    public class Context
    {
        private static Context singleObject;
        private List<SinhVien> listSV;
        private ISVDataSource dataSource;

        private Context(ISVDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public static Context getInstance(ISVDataSource dataSource)
        {
            if(singleObject == null)
            {
                singleObject = new Context(dataSource);
            }
            return singleObject;
        }
        
        public List<SinhVien> GetSV()
        {
            if (listSV == null) listSV = dataSource.GetSV();
            return listSV;
        }

        public void SaveSV()
        {
            dataSource.Save(listSV);
        }
    }
}
