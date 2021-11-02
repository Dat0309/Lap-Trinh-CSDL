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

            conn.Close();
        }
    }
}
