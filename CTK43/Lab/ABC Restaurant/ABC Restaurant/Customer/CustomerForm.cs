using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_Restaurant.Customer;

namespace ABC_Restaurant.Customer
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        public void initUI() 
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Customers";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            
            dgvCustomer.DataSource = dt;
            dgvCustomer.Columns[0].ReadOnly = true;
            dgvCustomer.Columns[0].HeaderText = "ID";
            dgvCustomer.Columns[1].HeaderText = "Nhà cung cấp";
            dgvCustomer.Columns[2].HeaderText = "Tên liên lạc";
            dgvCustomer.Columns[3].HeaderText = "Tiêu đề";
            dgvCustomer.Columns[4].HeaderText = "Địa chỉ";
            dgvCustomer.Columns[5].HeaderText = "Thành phố";
            dgvCustomer.Columns[6].HeaderText = "Vùng";
            dgvCustomer.Columns[7].HeaderText = "Mã bưu điện";
            dgvCustomer.Columns[8].HeaderText = "Quốc gia";
            dgvCustomer.Columns[9].HeaderText = "Điện thoại";
            dgvCustomer.Columns[10].HeaderText = "Fax";

            conn.Close();
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            var customerID = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            OrderForm frm = new OrderForm();
            frm.iniUI(customerID);
            frm.Show(this);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
