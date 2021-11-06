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

namespace ABC_Restaurant.Products
{
    public partial class ProductForm : Form
    {
        private static ProductForm? singleObject;
        private DataTable? table, dtcbb;
        private bool isSelect = true;

        public ProductForm()
        {
            InitializeComponent();
        }
        public static ProductForm getInstance()
        {

            if (singleObject == null)
            {
                singleObject = new ProductForm();
            }
            return singleObject;
        }


        public void initUI()
        {
            cbbGroup.Visible = false;
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            table = new DataTable();

            conn.Open();

            adapter.Fill(table);
            dgvProduct.DataSource = table;
            dgvProduct.Columns[0].ReadOnly = true;
            dgvProduct.Columns[0].HeaderText = "Mã sản phẩm";
            dgvProduct.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns[2].HeaderText = "Nhà cung cấp";
            dgvProduct.Columns[3].HeaderText = "Danh mục sản phẩm";
            dgvProduct.Columns[4].HeaderText = "Số lượng mõi đơn vị";
            dgvProduct.Columns[5].HeaderText = "Đơn vị giá";
            dgvProduct.Columns[6].HeaderText = "Đơn vị tồn";
            dgvProduct.Columns[7].HeaderText = "Đơn vị mỗi lần mua";
            dgvProduct.Columns[8].HeaderText = "Cấp độ mua";
            dgvProduct.Columns[9].HeaderText = "Tình trạng";

            conn.Close();
        }

        public void LoadListCategory()
        {
            isSelect = false;
            cbbGroup.Visible = true;
            loadCategory();
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products where CategoryID = @catID";
            cmd.Parameters.Add("@catID", SqlDbType.Int);
            cmd.Parameters["@catID"].Value = cbbGroup.SelectedValue;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            table = new DataTable();

            conn.Open();

            adapter.Fill(table);
            dgvProduct.DataSource = table;
            dgvProduct.Columns[0].ReadOnly = true;

            conn.Close();
        }
        public void LoadListSupp()
        {
            isSelect = true;
            cbbGroup.Visible = true;
            loadSupp();
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products where SupplierID = @catID";
            cmd.Parameters.Add("@catID", SqlDbType.Int);
            cmd.Parameters["@catID"].Value = cbbGroup.SelectedValue;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            table = new DataTable();

            conn.Open();

            adapter.Fill(table);
            dgvProduct.DataSource = table;
            dgvProduct.Columns[0].ReadOnly = true;

            conn.Close();
        }

        private void loadCategory()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT CatID, CatName FROM Categories";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dtcbb = new DataTable();
            conn.Open();

            adapter.Fill(dtcbb);
            conn.Close();
            conn.Dispose();

            cbbGroup.DataSource = dtcbb;
            cbbGroup.DisplayMember = "CatName";
            cbbGroup.ValueMember = "CatID";
        }
        private void loadSupp()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT SupplierID, CompanyName FROM Suppliers";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dtcbb = new DataTable();
            conn.Open();

            adapter.Fill(dtcbb);
            conn.Close();
            conn.Dispose();

            cbbGroup.DataSource = dtcbb;
            cbbGroup.DisplayMember = "CompanyName";
            cbbGroup.ValueMember = "SupplierID";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (table == null) return;

            string filterExpression = String.Format("ProductName like '%{0}%'", txtSearch.Text);
            string sortExpression = "ProductName";
            DataViewRowState dataViewRowState = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(table, filterExpression, sortExpression, dataViewRowState);

            dgvProduct.DataSource = foodView;
        }

        private void cbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGroup.SelectedIndex == -1) return;
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products Where CategoryID = @categoryId or SupplierID = @suppId";

            cmd.Parameters.Add("@categoryId", SqlDbType.Int);
            cmd.Parameters.Add("@suppId", SqlDbType.Int);
            if (cbbGroup.SelectedValue is DataRowView)
            {
                if (isSelect)
                {
                    cmd.Parameters["@categoryId"].Value = 0;
                    cmd.Parameters["@suppId"].Value = 1;
                }
                else
                {
                    cmd.Parameters["@categoryId"].Value = 1;
                    cmd.Parameters["@suppId"].Value = 0;
                }
            }
            else
            {
                if (isSelect)
                {
                    cmd.Parameters["@categoryId"].Value = 0;
                    cmd.Parameters["@suppId"].Value = cbbGroup.SelectedValue;
                }
                else
                {
                    cmd.Parameters["@categoryId"].Value = cbbGroup.SelectedValue;
                    cmd.Parameters["@suppId"].Value = 0;
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            table = new DataTable();

            conn.Open();

            adapter.Fill(table);

            conn.Close();
            conn.Dispose();

            dgvProduct.DataSource = table;

            dgvProduct.Columns[0].ReadOnly = true;

        }

    }
}
