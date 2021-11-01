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

namespace Lab07
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE Bills_GetByDate @date";

                cmd.Parameters.Add("@date", SqlDbType.SmallDateTime);
                cmd.Parameters["@date"].Value = dpkDate.Value.ToShortDateString();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();

                adapter.Fill(dt);
                cmd.CommandText = "Select SUM(Amount) from Bills where CheckoutDate = @date";

                var doanhThu = cmd.ExecuteScalar();
                lbDoanhThu.Text = doanhThu.ToString();

                conn.Close();

                dgvHoaDon.DataSource = dt;
                dgvHoaDon.Columns[0].ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }

        }

        private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            var billID = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();

            OrderDetailsForm frm = new OrderDetailsForm();
            frm.LoadDetail(billID);
            frm.ShowDialog(this);
        }
    }
}
