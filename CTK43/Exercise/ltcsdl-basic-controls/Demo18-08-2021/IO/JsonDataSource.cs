using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo18_08_2021.DTO;
using System.IO;
using Newtonsoft.Json;

namespace Demo18_08_2021.IO
{
    public class JsonDataSource : IDataSource
    {
        private string fileName;

        public JsonDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public List<Food> GetFoods()
        {
            List<Food> foods = new List<Food>();
            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(fileName))
                {
                    var json = reader.ReadToEnd();
                    foods = JsonConvert.DeserializeObject<List<Food>>(json);
                }
            }
            return foods;
        }

        public void Save(List<Food> foods)
        {
            var foodData = JsonConvert.SerializeObject(foods);
            File.WriteAllText(fileName, foodData);
        }


    }
}
