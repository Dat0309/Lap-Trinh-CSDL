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
    public partial class FormEdit : Form
    {
        public DTO.Food returnFood;
        public int _Id;
        public string name;
        public string unit;
        public string description;
        public string link;
        public int unitPrice;
        public int category;

        public FormEdit()
        {
            InitializeComponent();
           
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            cbbCategory.DataSource = WorkingContext.CategoryList;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "Id";

            txtId.Text = _Id.ToString();
            txtName.Text = name.ToString();
            txtUnit.Text = unit.ToString();
            nudUnitPrice.Value = unitPrice;
            txtPic.Text = link;
            cbbCategory.SelectedValue = category;
            try
            {
                pictureBox1.Load(link);
            }
            catch (Exception)
            {
                pictureBox1.Load("food.png");
            }

        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var name = txtName.Text;
            var unit = txtUnit.Text;
            var description = etbDetail.Text;
            var link = txtPic.Text;
            var price = Convert.ToInt32(nudUnitPrice.Value);
            var category = Convert.ToInt32(cbbCategory.SelectedValue);

            var foods = WorkingContext.FoodList.FirstOrDefault(p => p.Id == id);
            foods.Name = name;
            foods.Unit = unit;
            foods.UnitPrice = price;
            foods.CategoryId = category;
            foods.Description = description;
            foods.ImageLink = link;

            DialogResult = DialogResult.OK;
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
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var fileName = dlg.FileName;
                txtPic.Text = fileName;
                pictureBox1.Load(fileName);
            }
        }
    }
}
