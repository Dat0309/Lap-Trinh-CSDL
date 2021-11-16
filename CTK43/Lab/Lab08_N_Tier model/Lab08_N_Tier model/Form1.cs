using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace Lab08_N_Tier_model
{
    public partial class Form1 : Form
    {

        List<Category> categories = new List<Category>();
        List<Food> foods = new List<Food>();
        Food foodCurrent = new Food();

        public Form1()
        {
            InitializeComponent();
        }

        #region cac ham xu ly

        public int InsertFood()
        {
            Food food = new Food();
            food.ID = 0;
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chua nhap du lieu cho cac o, vui long nhap lai");
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtPrice.Text;

                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price = price;
                food.FoodCategoryID = int.Parse(cbbCate.SelectedValue.ToString());
                FoodBL foodBL = new FoodBL();
                return foodBL.Insert(food);
            }
            return -1;
        }

        public int UpdateFood()
        {
            Food food = foodCurrent;
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chua nhap du lieu cho cac o, vui long nhap lai");
            else
            {
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;

                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    price=0;
                }
                food.Price = price;
                food.FoodCategoryID = int.Parse(cbbCate.SelectedValue.ToString());
                FoodBL foodBL = new FoodBL();
                return foodBL.Update(food);
            }
            return -1;
        }

        #endregion
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "0";
            txtUnit.Text = "";
            cbbCate.Text = "";
            if (cbbCate.Items.Count > 0)
                cbbCate.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodDataToListView();
        }

        private void LoadFoodDataToListView()
        {
            FoodBL foodBL = new FoodBL();
            foods = foodBL.GetAll();
            int count = 1;
            lvFood.Items.Clear();

            foreach(Food food in foods)
            {
                ListViewItem item = lvFood.Items.Add(count.ToString());

                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());

                string catName = categories.Find(x => x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(catName);
                item.SubItems.Add(food.Notes);
                count++;
            }
        }

        private void LoadCategory()
        {
            CategoryBL catBL = new CategoryBL();
            categories = catBL.GetAll();
            cbbCate.DataSource = categories;
            cbbCate.ValueMember = "ID";
            cbbCate.DisplayMember = "Name";
        }

        private void lvFood_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< lvFood.Items.Count; i++)
            {
                if (lvFood.Items[i].Selected)
                {
                    foodCurrent = foods[i];
                    txtName.Text = foodCurrent.Name;
                    txtUnit.Text = foodCurrent.Unit;
                    txtPrice.Text = foodCurrent.Price.ToString();
                    txtNotes.Text = foodCurrent.Notes;

                    cbbCate.SelectedIndex = categories.FindIndex(x => x.ID == foodCurrent.FoodCategoryID);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = InsertFood();
            if (result > 0)
            {
                MessageBox.Show("Them du lieu hanh cong");
                LoadFoodDataToListView();
            }
            else MessageBox.Show("Them du lieu khong thanh cong. Vui long kiem tra lai du lieu nhap");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac chan muon xoa mau tin nay?", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FoodBL foodBL = new FoodBL();
                if (foodBL.Delete(foodCurrent) > 0)
                {
                    MessageBox.Show("Xoa thuc pham thanh cong");
                    LoadFoodDataToListView();
                }
                else
                    MessageBox.Show("Xoa khong thanh cong");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateFood();
            if (result > 0)
            {
                MessageBox.Show("Cap nhat du lieu thanh cong");
                LoadFoodDataToListView();
            }
            else MessageBox.Show("Cap nhat du lieu khong thanh cong. vVui long kiem tra lai du lieu nhap");

        }
    }

}
