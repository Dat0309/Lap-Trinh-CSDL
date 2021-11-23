﻿using System;
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
    public partial class UpdateFoodForm : Form
    {
        private RestaurantContext _dbContext;
        private int _foodId;

        public UpdateFoodForm(int? foodId = null)
        {
            InitializeComponent();

            _dbContext = new RestaurantContext();
            _foodId = foodId ?? 0;
        }

        #region Cac ham xu ly

        /// <summary>
        /// Hàm xuất danh sách nhóm món ăn lên combobox
        /// </summary>
        private void LoadCategoriesToCombobox()
        {
            var categories = _dbContext.Categories.OrderBy(x=>x.Name).ToList();

            cbbFoodCategory.DisplayMember = "Name";
            cbbFoodCategory.ValueMember = "Id";
            cbbFoodCategory.DataSource = categories;
        }

        /// <summary>
        /// Hàm xuất món ăn theo id
        /// </summary>
        /// <param name="foodId"></param>
        /// <returns></returns>
        private Food GetFoodById(int foodId)
        {
            return foodId > 0? _dbContext.Foods.Find(foodId) : null;
        }

        /// <summary>
        /// Hàm xuất thông tin của món ăn
        /// </summary>
        private void ShowFoodInformation()
        {
            var food = GetFoodById(_foodId);
            if (food == null) return;

            txtFoodId.Text = food.Id.ToString();
            txtFoodName.Text = food.Name;
            cbbFoodCategory.SelectedValue = food.FoodCategoryId;
            txtFoodUnit.Text = food.Unit;
            nudFoodPrice.Value = food.Price;
            txtFoodNotes.Text = food.Notes;
        }

        /// <summary>
        /// Hàm kiểm tra dữ liệu đầu vào của người dùng
        /// </summary>
        /// <returns></returns>
        private bool ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Tên món ăn, đồ uống không được để trống", "Thông báo");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFoodUnit.Text))
            {
                MessageBox.Show("Đơn vị tính không được đẻe trống", "Thông báo");
                return false;
            }

            if (nudFoodPrice.Value.Equals(0))
            {
                MessageBox.Show("Giá của thức ăn phải lớn hơn 0", "Thông báo");
                return false;
            }

            if (cbbFoodCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn nhóm thức ăn", "Thông báo");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Hàm lấy thông tin trên controll để update cho các món ăn
        /// </summary>
        /// <returns></returns>
        private Food GetUpdatedFood()
        {
            var food = new Food()
            {
                Name = txtFoodName.Text.Trim(),
                FoodCategoryId = (int)cbbFoodCategory.SelectedValue,
                Unit = txtFoodUnit.Text.Trim(),
                Price = (int)nudFoodPrice.Value,
                Notes = txtFoodNotes.Text.Trim()
            };

            if (_foodId > 0)
                food.Id = _foodId;
            return food;
        }

        #endregion

        private void UpdateFoodForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToCombobox();
            ShowFoodInformation();
        }

        /// <summary>
        /// Sự kiện nhấn nút lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                var newFood = GetUpdatedFood();
                var oldFood = GetFoodById(_foodId);

                if(oldFood == null)
                    _dbContext.Foods.Add(newFood);
                else
                {
                    oldFood.Name = newFood.Name;
                    oldFood.FoodCategoryId = newFood.FoodCategoryId;
                    oldFood.Unit = newFood.Unit;
                    oldFood.Price = newFood.Price;
                    oldFood.Notes = newFood.Notes;
                }

                _dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
