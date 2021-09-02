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
        public DTO.Food returnFood;
        private Contex context;
        private List<DTO.Food> foods;

        public ControlFoodForm(Contex context, int foodId = 0)
        {
            InitializeComponent();
            _foodId = foodId;
            this.context = context;
            foods = context.GetFood();
        }

        private void ControlFoodForm_Load(object sender, EventArgs e)
        {
            cbbCategory.DataSource = WorkingContext.CategoryList;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "Id";
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Picture";
            dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
                + "*.jpg;*.jpeg;*.gif;*.bmp;"
                + "*.tif;*.tiff;*.png|"
                + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
                + "GIF files (*.gif)|*.gif|"
                + "BMP files (*.bmp)|*.bmp|"
                + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
                + "PNG files (*.png)|*.png|"
                + "All files (*.*)|*.*";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                var fileName = dlg.FileName;
                txtPic.Text = fileName;
                pictureBox1.Load(fileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var unit = txtUnit.Text;
            var description = etbDetail.Text;
            var link = txtPic.Text;
            var price = Convert.ToInt32(nudUnitPrice.Value);
            var category = Convert.ToInt32(cbbCategory.SelectedValue);

            if (_foodId == 0)
            {
                int id = foods.Any() ? foods.Max(f => f.Id) + 1 : 1;
                returnFood = new DTO.Food(id, name, unit, price, description, link, category);
                foods.Add(returnFood);
            }
            else
            {

            }
            DialogResult = DialogResult.OK;
        }
    }
}
