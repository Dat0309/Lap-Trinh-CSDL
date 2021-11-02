using System.Data.SqlClient;
using ABC_Restaurant.Customer;
using ABC_Restaurant.Supplier;

namespace ABC_Restaurant
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tsmAddCustomers_Click(object sender, EventArgs e)
        {
            count++;
            NewCustomerForm frm = new NewCustomerForm();
            frm.MdiParent = this;
            frm.Show();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            frm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmListCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            frm.MdiParent = this;
            count++;
            frm.initUI();
            frm.Size = new System.Drawing.Size(1100, 500);
            frm.Show();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            frm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }
        private void formClosed(object sender, FormClosedEventArgs e)
        {
            count--;
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmAddSuppliers_Click(object sender, EventArgs e)
        {
            count++;
            NewCustomerForm frm = new NewCustomerForm();
            frm.MdiParent = this;
            frm.Show();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            frm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

        private void tsmListSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersForm frm = new SuppliersForm();
            frm.MdiParent = this;
            count++;
            frm.initUI();
            frm.Size = new System.Drawing.Size(1100, 500);
            frm.Show();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            frm.FormClosed += new FormClosedEventHandler(formClosed);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            tsStatus.Text = "Số cửa sổ đang mở: " + count.ToString();
        }

    }
}