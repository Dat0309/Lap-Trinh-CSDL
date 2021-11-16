using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class CategoryBL
    {
        CategoryDA catDA = new CategoryDA();

        public List<Category> GetAll()
        {
            return catDA.GetAll();
        }

        public int Insert(Category cat)
        {
            return catDA.Insert_Update_Delete(cat, 0);
        }
        public int Update(Category cat)
        {
            return catDA.Insert_Update_Delete(cat, 1);
        }

        public int Delete(Category cat)
        {
            return catDA.Insert_Update_Delete(cat, 2);
        }
    }
}
