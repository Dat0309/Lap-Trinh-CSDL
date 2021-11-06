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

namespace ABC_Restaurant.Supplier
{
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
        }

        public void initUI()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Suppliers";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            dgvSupplier.DataSource = dt;
            dgvSupplier.Columns[0].ReadOnly = true;
            dgvSupplier.Columns[0].HeaderText = "Mã đối tác";
            dgvSupplier.Columns[1].HeaderText = "Công ty";
            dgvSupplier.Columns[2].HeaderText = "Liên lạc";
            dgvSupplier.Columns[3].HeaderText = "Địa chỉ";
            dgvSupplier.Columns[4].HeaderText = "Thành phố";
            dgvSupplier.Columns[5].HeaderText = "Khu vực";
            dgvSupplier.Columns[6].HeaderText = "Mã bưu điện";
            dgvSupplier.Columns[7].HeaderText = "Quốc gia";
            dgvSupplier.Columns[8].HeaderText = "Điện thoại";
            dgvSupplier.Columns[9].HeaderText = "Fax";
            dgvSupplier.Columns[10].HeaderText = "Trang web";

            conn.Close();
        }

        private void dgvSupplier_DoubleClick(object sender, EventArgs e)
        {
            var suppliersID = dgvSupplier.SelectedRows[0].Cells[0].Value.ToString();
            ProductForrm frm = new ProductForrm();
            frm.iniUI(suppliersID);
            frm.Show(this);
        }
    }
}
