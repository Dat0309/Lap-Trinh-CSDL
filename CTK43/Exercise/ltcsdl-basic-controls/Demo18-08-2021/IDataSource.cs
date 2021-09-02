using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_08_2021
{
    public interface IDataSource
    {
        List<DTO.Food> GetFoods();
        void Save(List<DTO.Food> foods);
    }
}
