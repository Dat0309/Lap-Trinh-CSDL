using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int FoodCategoryID { get; set; }
        public int Price { get; set; }
        public string Notes { get; set; }
    }
}
