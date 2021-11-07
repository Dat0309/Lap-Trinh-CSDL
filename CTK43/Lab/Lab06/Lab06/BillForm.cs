using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab06
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        public void LoadBills(string fromTime, string toTime)
        {
            string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = String.Format("SELECT * FROM Bills WHERE CheckoutDate BETWEEN '{0}' AND '{1}'",fromTime,toTime);
            connection.Open();
            //string categoryName = command.ExecuteScalar().ToString();
            this.Text = "Danh sach hoa don tu ngay " + fromTime + " toi ngay " + toTime;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable("Food");
            adapter.Fill(dt);

            dgvBill.DataSource = dt;

            dgvBill.Columns[0].ReadOnly = true;

            dgvBill.Columns[0].HeaderText = "Mã đơn hàng";
            dgvBill.Columns[1].HeaderText = "Tên đơn hàng";
            dgvBill.Columns[2].HeaderText = "Mã bàn";
            dgvBill.Columns[3].HeaderText = "Tổng tiền";
            dgvBill.Columns[4].HeaderText = "Giảm giá";
            dgvBill.Columns[5].HeaderText = "Thuế";
            dgvBill.Columns[6].HeaderText = "Tình trạng thanh toán";
            dgvBill.Columns[7].HeaderText = "Ngày nhập";
            dgvBill.Columns[8].HeaderText = "Nhân viên";

            connection.Close();
            connection.Dispose();
            adapter.Dispose();
        }

        private void dgvBill_DoubleClick(object sender, EventArgs e)
        {
            BillDetailForm frm = new BillDetailForm();
            string id = dgvBill.SelectedRows[0].Cells[0].Value.ToString();
            frm.Show(this);
            frm.LoadBillDetail(int.Parse(id));
        }
    }
}
