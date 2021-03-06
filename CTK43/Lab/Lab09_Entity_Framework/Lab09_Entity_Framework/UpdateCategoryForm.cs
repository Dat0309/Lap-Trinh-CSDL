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
    public partial class UpdateCategoryForm : Form
    {
        private RestaurantContext _dbContext;
        private int _categoryId;
        public UpdateCategoryForm(int? categoryId = null)
        {
            InitializeComponent();

            _dbContext = new RestaurantContext();
            _categoryId = categoryId ?? 0;
        }

        #region Cac ham xu ly

        /// <summary>
        /// Hàm xuất nhóm món ăn theo id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        private Category? GetCategoryById(int categoryId)
        {
            return categoryId > 0 ? _dbContext.Categories.Find(categoryId) : null;
        }

        /// <summary>
        /// Hàm xuất nhóm món ăn
        /// </summary>
        private void ShowCategory()
        {
            var category = GetCategoryById(_categoryId);

            if (category == null) return;

            txtCategoryId.Text = category.Id.ToString();
            txtCategoryName.Text = category.Name;
            cbbCategoryType.SelectedIndex = (int)category.Type;
        }

        /// <summary>
        /// Hàm lấy thông tin update nhóm món ăn treen controller
        /// </summary>
        /// <returns></returns>
        private Category GetUpdateCategory()
        {
            var category = new Category()
            {
                Name = txtCategoryName.Text.Trim(),
                Type = (CategoryType)cbbCategoryType.SelectedIndex
            };

            if(_categoryId > 0)
                category.Id = _categoryId;
            return category;
        }

        /// <summary>
        /// Hàm kiểm tra thông tin người dùng nhập vào
        /// </summary>
        /// <returns></returns>
        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Ten nhom thuuc an khong duoc de trong", "Thong bao");
                return false;
            }

            if(cbbCategoryType.SelectedIndex < 0)
            {
                MessageBox.Show("Ban chua chon loai nhom thuc an", "Thong bao");
                return false;
            }
            return true;
        }
        #endregion

        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            ShowCategory();
        }

        /// <summary>
        /// Sự kiện nút lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                var newCategory = GetUpdateCategory();
                var oldCategory = GetCategoryById(_categoryId);
                if(oldCategory == null)
                {
                    _dbContext.Categories.Add(newCategory);
                }
                else
                {
                    oldCategory.Name = newCategory.Name;
                    oldCategory.Type = newCategory.Type;
                }

                _dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
