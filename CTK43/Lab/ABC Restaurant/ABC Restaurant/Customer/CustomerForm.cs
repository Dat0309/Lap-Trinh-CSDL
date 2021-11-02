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

            conn.Close();
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            var customerID = dgvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            OrderForm frm = new OrderForm();
            frm.iniUI(customerID);
            frm.Show(this);
        }
    }
}
