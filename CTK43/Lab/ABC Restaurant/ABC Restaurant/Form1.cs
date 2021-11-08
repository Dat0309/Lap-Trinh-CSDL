using System.Data.SqlClient;
using ABC_Restaurant.Customer;
using ABC_Restaurant.Supplier;
using ABC_Restaurant.Employees;
using ABC_Restaurant.Products;
using ABC_Restaurant.Orders;

namespace ABC_Restaurant
{
    public partial class Form1 : Form
    {
        private ProductForm frmProduct;
        private CustomerForm customerfrm;
        private SuppliersForm supplierFrm;
        private ListEmployFrm employFrm;
        private Orders.OrderForm orderForm;

        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                tsccbFont.Items.Add(font.Name.ToString());
            }
        }

        private void tsmAddCustomers_Click(object sender, EventArgs e)
        {
            count++;
            NewCustomerForm frm = new NewCustomerForm();
            DialogResult dlg = frm.ShowDialog(this);
            if (dlg == DialogResult.OK)
            {
                customerfrm.initUI();
            }
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            frm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmListCustomer_Click(object sender, EventArgs e)
        {
            customerfrm = new CustomerForm();
            customerfrm.MdiParent = this;
            count++;
            customerfrm.initUI();
            customerfrm.Size = new System.Drawing.Size(1100, 500);
            customerfrm.Show();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            customerfrm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }
        private void formClosed(object sender, FormClosedEventArgs e)
        {
            resetCheck();
            count--;
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmAddSuppliers_Click(object sender, EventArgs e)
        {
            count++;
            NewSuppliers frm = new NewSuppliers();
            DialogResult dlg = frm.ShowDialog(this);
            if (dlg == DialogResult.OK)
            {
                supplierFrm.initUI();
            }
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            frm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmListSuppliers_Click(object sender, EventArgs e)
        {
            supplierFrm = new SuppliersForm();
            supplierFrm.MdiParent = this;
            count++;
            supplierFrm.initUI();
            supplierFrm.Size = new System.Drawing.Size(1100, 500);
            supplierFrm.Show();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            supplierFrm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmAddEmployees_Click(object sender, EventArgs e)
        {
            count++;
            NewEmployForm frm = new NewEmployForm();
            DialogResult dlg = frm.ShowDialog(this);
            if (dlg == DialogResult.OK)
            {
                employFrm.initUI();
            }
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            frm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmListEmployeers_Click(object sender, EventArgs e)
        {
            employFrm = new ListEmployFrm();
            employFrm.MdiParent = this;
            count++;
            employFrm.initUI();
            employFrm.Size = new System.Drawing.Size(1100, 500);
            employFrm.Show();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            employFrm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmAll_Click(object sender, EventArgs e)
        {
            frmProduct = new ProductForm();
            resetCheck();
            tsmAll.Checked = true;
            frmProduct.MdiParent = this;
            count++;
            frmProduct.initUI();
            frmProduct.Size = new System.Drawing.Size(1100, 500);
            frmProduct.Show();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            frmProduct.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmCategory_Click(object sender, EventArgs e)
        {
            resetCheck();
            tsmCategory.Checked = true;
            frmProduct.LoadListCategory();
            frmProduct.Update();
            frmProduct.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmSupp_Click(object sender, EventArgs e)
        {
            resetCheck();
            tsmSupp.Checked = true;
            frmProduct.LoadListSupp();
            frmProduct.Update();
            frmProduct.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void resetCheck()
        {
            tsmAll.Checked = false;
            tsmCategory.Checked = false;
            tsmSupp.Checked = false;
        }

        private void tsmNewProduct_Click(object sender, EventArgs e)
        {
            count++;
            NewProductForm frm = new NewProductForm();
            DialogResult dlg = frm.ShowDialog(this);
            if (dlg == DialogResult.OK)
            {
                frmProduct.initUI();
            }
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            frm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmStatitics_Click(object sender, EventArgs e)
        {

        }

        private void tsmListOrders_Click(object sender, EventArgs e)
        {
            orderForm = new Orders.OrderForm();
            orderForm.MdiParent = this;
            count++;
            orderForm.initUI();
            orderForm.Size = new System.Drawing.Size(1100, 500);
            orderForm.Show();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            orderForm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmNewOrder_Click(object sender, EventArgs e)
        {

        }

        private void tsccbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Font = new Font(tsccbFont.Text, this.Font.Size);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }
        }

        private void tsccbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Font = new Font(this.Font.FontFamily, float.Parse(tsccbSize.SelectedItem.ToString()));
            }
            catch { }
        }

        private void tsbColor_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.colorDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                this.ForeColor = colorDialog1.Color;
            }
        }
    }
}