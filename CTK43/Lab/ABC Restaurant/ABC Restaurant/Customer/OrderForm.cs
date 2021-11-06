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

namespace ABC_Restaurant.Customer
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public void iniUI(string customerID)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Orders WHERE CustomerID = " + customerID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            dgvOrder.DataSource = dt;
            dgvOrder.Columns[0].ReadOnly = true;
            dgvOrder.Columns[0].HeaderText = "Mã Hoá đơn";
            dgvOrder.Columns[1].HeaderText = "Mã khách hàng";
            dgvOrder.Columns[2].HeaderText = "Mã Nhân viên";
            dgvOrder.Columns[3].HeaderText = "Ngày nhập đơn";
            dgvOrder.Columns[4].HeaderText = "Ngày yêu cầu";
            dgvOrder.Columns[5].HeaderText = "Ngày giao hàng";
            dgvOrder.Columns[6].HeaderText = "Vận chuyển";
            dgvOrder.Columns[7].HeaderText = "Freight";
            dgvOrder.Columns[8].HeaderText = "Tên người vận chuyển";
            dgvOrder.Columns[9].HeaderText = "Địa chỉ";
            dgvOrder.Columns[10].HeaderText = "Thành phố";
            dgvOrder.Columns[11].HeaderText = "Khu vực";
            dgvOrder.Columns[12].HeaderText = "Mã bưu điện";
            dgvOrder.Columns[13].HeaderText = "Quốc gia";

            conn.Close();
        }
    }
}
