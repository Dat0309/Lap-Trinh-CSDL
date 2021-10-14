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
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
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
