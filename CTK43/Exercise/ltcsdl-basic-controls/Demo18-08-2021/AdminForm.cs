﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo18_08_2021.DTO;

namespace Demo18_08_2021
{
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			LoadTableToLvDetail();
			LoadTableFoodDetail(WorkingContext.FoodList);
			LoadCategory();
			SetUpSearch();
		}
		private void LoadTableToLvDetail()
		{
			lvTableList.Items.Clear();
			foreach (var table in WorkingContext.TableList)
			{
				ListViewItem item = new ListViewItem(table.TableId.ToString());
				item.SubItems.Add(table.TableName);
				item.SubItems.Add(table.Status == 1 ? "Có người" : "Trống");
				item.SubItems.Add(table.Floor.ToString());

				lvTableList.Items.Add(item);
			}
		}


		private void LoadTableFoodDetail(List<Food> list)
        {
			lvFoodList.Items.Clear();
            foreach (var food in list)
            {
				ListViewItem item = new ListViewItem(food.Id.ToString());
				item.SubItems.Add(food.Name);
				item.SubItems.Add(food.Unit);
				item.SubItems.Add(food.UnitPrice.ToString());
				item.SubItems.Add(food.CategoryId.ToString());
				item.SubItems.Add(food.Description);
				item.SubItems.Add(food.ImageLink);

				lvFoodList.Items.Add(item);
            }
        }

		private void LoadCategory()
        {
            foreach (var cat in WorkingContext.CategoryList)
            {
				int id = cat.Id;
				Button btn = new Button();
				btn.Text = cat.Name;
				btn.BackColor = Color.LightBlue;
				btn.Height = 40;
				btn.Width = 250;
				btn.Tag = id;
				btn.Click += CategoryBtn_Click;

				flpCategory.Controls.Add(btn);
            }
        }

		private void CategoryBtn_Click(object sender, EventArgs e)
        {
			int _currentCategory = Convert.ToInt32((sender as Button).Tag);
			var foods = WorkingContext.FoodList;
			if(_currentCategory > 0)
            {
				foods = foods.Where(f => f.CategoryId == _currentCategory).ToList();
            }
			LoadTableFoodDetail(foods);
        }

		private void SetUpSearch()
        {
			txtSearch.Text = "Nhập vào tên món ăn";
			txtSearch.GotFocus += RemovePlaceHolderText;
			txtSearch.LostFocus += ShowPlaceHolderText;
        }

		private void ShowPlaceHolderText(object sender, EventArgs e)
        {
			if (string.IsNullOrWhiteSpace(txtSearch.Text))
				txtSearch.Text = "Nhập vào tên món ăn";
        }

		private void RemovePlaceHolderText(object sender, EventArgs e)
        {
			if (txtSearch.Text == "Nhập vào tên món ăn")
				txtSearch.Text = "";
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var tableName = txtTableName.Text;
			var floor = int.Parse(cbbFloor.Text);
			var tableId = WorkingContext.TableList.Max(p => p.TableId) + 1;

			DiningTable table = new DiningTable(tableId, tableName, floor);
			WorkingContext.TableList.Add(table);

			LoadTableToLvDetail();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var tableName = txtTableName.Text;
			var floor = int.Parse(cbbFloor.Text);
			var tableId = int.Parse(txtTableId.Text);

			var table = WorkingContext.TableList.FirstOrDefault(p => p.TableId == tableId);
			table.TableName = tableName;
			table.Floor = floor;

			LoadTableToLvDetail();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var tableId = int.Parse(txtTableId.Text);

			WorkingContext.TableList.RemoveAll(p => p.TableId == tableId);
			LoadTableToLvDetail();
		}

		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			var listCheckedItem = lvTableList.CheckedItems;

			foreach (ListViewItem item in listCheckedItem)
			{
				var id = int.Parse(item.SubItems[0].Text);
				WorkingContext.TableList.RemoveAll(p => p.TableId == id);
			}

			LoadTableToLvDetail();
		}

		private void lvTableList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var count = lvTableList.SelectedItems.Count;

			if (count > 0)
			{
				var item = lvTableList.SelectedItems[0];

				txtTableId.Text = item.SubItems[0].Text;
				txtTableName.Text = item.SubItems[1].Text;
				cbbFloor.SelectedIndex = int.Parse(item.SubItems[3].Text) - 1;

				btnDelete.Enabled = true;
				btnUpdate.Enabled = true;
			}
		}


        private void button1_Click(object sender, EventArgs e)
        {
			ControlFoodForm formFood = new ControlFoodForm();
			formFood.ShowDialog();
        }
    }
}
