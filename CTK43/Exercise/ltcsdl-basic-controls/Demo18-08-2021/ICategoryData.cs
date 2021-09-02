using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_08_2021
{
    public interface ICategoryData
    {
        List<DTO.Category> GetCategory();
        void Save(List<DTO.Category> categories);
    }
}
