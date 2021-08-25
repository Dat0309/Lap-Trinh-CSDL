using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo18_08_2021
{
    public partial class ControlFoodForm : Form
    {
        private int _foodId;
        
        public ControlFoodForm(int foodId = 0)
        {
            InitializeComponent();
            _foodId = foodId;
        }

        private void ControlFoodForm_Load(object sender, EventArgs e)
        {
            cbbCategory.DataSource = WorkingContext.CategoryList;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "Id";
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var name = txtName.Text;
            //var unit = txtUnit.Text;
            //var description = etbDetail.Text;
            //var link = txtPic.Text;
            //var price = Convert.ToInt32(txtUnitPrince);
            //var category = Convert.ToInt32(cbbCategory.SelectedValue);

            //if(_foodId == 0){
            //    int id = WorkingContext.FoodList.Any() ? WorkingContext.FoodList.Max(f => f.Id) + 1 : 1;
            //    var food = new Food(id, name, unit, price, description, link, category);
            //}
        }
    }
}
