using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo18_08_2021.DTO;
using System.IO;

namespace Demo18_08_2021.IO
{
    public class CategoryDataSource :ICategoryData
    {
        private string fileName;

        public CategoryDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public List<Category> GetCategory()
        {
            List<Category> categories = new List<Category>();
            if(File.Exists(fileName))
            {
                using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var sr = new StreamReader(stream))
                    {
                        string line;
                        while((line = sr.ReadLine()) != null)
                        {
                            categories.Add(ParseCate(line));
                        }
                    }
                }
            }

            return categories;
        }

        public void Save(List<Category> categories)
        {
            using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
            {
                using (var writer = new StreamWriter(stream))
                {
                    foreach (var item in categories)
                    {
                        var line = CatFormat(item);
                        writer.WriteLine();
                    }
                }
            }
        }

        private Category ParseCate(string line)
        {
            var parts = line.Split('^');

            return new Category() { 
                Id = Convert.ToInt32(parts[0]),
                Name = parts[1]
            };
        }

        private string CatFormat(Category cate)
        {
            return string.Format("{0}^{1}", cate.Id, cate.Name);

        }
    }
}
