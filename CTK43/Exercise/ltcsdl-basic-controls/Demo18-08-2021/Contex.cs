using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo18_08_2021
{
    public class Contex
    {
        private List<DTO.Food> foods;
        private List<DTO.Category> categories;

        private IDataSource dataSource;
        private ICategoryData categoryData;

        public Contex(IDataSource dataSource,ICategoryData categoryData)
        {
            this.dataSource = dataSource;
            this.categoryData = categoryData;
        }

        public List<DTO.Food> GetFood()
        {
            if (foods == null)
                foods = dataSource.GetFoods();
            return foods;
        }

        public void SaveFood()
        {
            dataSource.Save(foods);
        }

        public List<DTO.Category> GetCate()
        {
            if (categories == null)
                categories = categoryData.GetCategory();
            return categories;
        }

        public void SaveCate()
        {
            categoryData.Save(categories);
        }
    }
}
