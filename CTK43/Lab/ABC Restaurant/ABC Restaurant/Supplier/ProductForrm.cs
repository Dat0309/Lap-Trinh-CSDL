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
    public partial class ProductForrm : Form
    {
        public ProductForrm()
        {
            InitializeComponent();
        }

        public void iniUI(string supplierID)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products WHERE SupplierID = " + supplierID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            dgvProduct.DataSource = dt;
            dgvProduct.Columns[0].ReadOnly = true;
            dgvProduct.Columns[0].HeaderText = "Mã sản phẩm";
            dgvProduct.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns[2].HeaderText = "Nhà cung cấp";
            dgvProduct.Columns[3].HeaderText = "Danh mục";
            dgvProduct.Columns[4].HeaderText = "Số lượng mỗi đơn vị";
            dgvProduct.Columns[5].HeaderText = "Đơn vị giá";
            dgvProduct.Columns[6].HeaderText = "Đơn vị tồn kho";
            dgvProduct.Columns[7].HeaderText = "Đơn vị mỗi đơn hàng";
            dgvProduct.Columns[8].HeaderText = "Cấp độ đặt hàng";
            dgvProduct.Columns[9].HeaderText = "Tình trạng";

            conn.Close();
        }
    }
}
