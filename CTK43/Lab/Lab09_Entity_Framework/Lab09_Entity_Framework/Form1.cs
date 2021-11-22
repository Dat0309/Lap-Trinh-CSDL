using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab09_Entity_Framework.Models;

namespace Lab09_Entity_Framework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Cac ham xu ly

        /// <summary>
        /// Lấy danh sách danh mục món ăn
        /// </summary>
        /// <returns></returns>
        private List<Category> GetCategories()
        {
            var dbContext = new RestaurantContext();
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }

        /// <summary>
        /// Xuất Danh sách danh mục món ăn
        /// </summary>
        /// 
        private void ShowCategories()
        {
            tvwCategory.Nodes.Clear();

            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink] = "Thức uống"
            };

            var rootNode = tvwCategory.Nodes.Add("Tất cả");

            var categories = GetCategories();
            foreach (var catType in cateMap)
            {
                var childNode = rootNode.Nodes.Add(catType.Key.ToString(), catType.Value);
                childNode.Tag = catType.Key;

                foreach (var category in categories)
                {
                    if (category.Type != catType.Key) continue;

                    var grantChildNode = childNode.Nodes.Add(category.Id.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }
            tvwCategory.ExpandAll();
            tvwCategory.SelectedNode = rootNode;
        }

        /// <summary>
        /// Lấy danh sách món ăn theo mã danh mục. Nếu mã này bằng null thì lấy tất cả các món ăn
        /// Sắp xếp món ăn tăng dần theo tên
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            var dbContext = new RestaurantContext();

            var foods = dbContext.Foods.AsQueryable();

            if (categoryId != null && categoryId > 0)
            {
                foods = foods.Where(x => x.FoodCategoryId == categoryId);
            }

            return foods
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                }).ToList();
        }

        /// <summary>
        /// Lấy danh sách món ăn hoặc đồ uống, tuỳ theo danh mục
        /// </summary>
        /// <param name="catType"></param>
        /// <returns></returns>
        private List<FoodModel> GetFoodByCategoryType(CategoryType catType)
        {
            var dbContext = new RestaurantContext();

            return dbContext.Foods
                .Where(x => x.Category.Type == catType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                }).ToList();
        }

        /// <summary>
        /// Kiểm tra xem nút đó ở mức nào để gọi các hàm tương ứng đã định nghĩa ở trên
        /// </summary>
        /// <param name="node"></param>
        private void ShowFoodsForNode(TreeNode node)
        {
            lvwFood.Items.Clear();
            if (node == null) return;
            List<FoodModel> foods = null;

            if(node.Level == 1)
            {
                var categoryType = (CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.Id);
            }
            ShowFoodsOnListView(foods);
        }

        /// <summary>
        /// Hiển thị các món ăn lên listview
        /// </summary>
        /// <param name="foods"></param>
        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach (var foodItem in foods)
            {
                var item = lvwFood.Items.Add(foodItem.Id.ToString());

                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString("##,###"));
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);
            }
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }
    }
}
