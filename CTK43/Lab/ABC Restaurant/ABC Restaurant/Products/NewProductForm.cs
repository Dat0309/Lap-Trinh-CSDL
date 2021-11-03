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
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertPrroduct @name,@suppid,@catid,@quantity,@price,@stock,@order,@lever,@active";

                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 250);
                cmd.Parameters.Add("@suppid", SqlDbType.Int);
                cmd.Parameters.Add("@catid", SqlDbType.Int);
                cmd.Parameters.Add("@quantity", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.NVarChar, 250);
                cmd.Parameters.Add("@stock", SqlDbType.NVarChar, 250);
                cmd.Parameters.Add("@order", SqlDbType.NVarChar, 250);
                cmd.Parameters.Add("@lever", SqlDbType.Int);
                cmd.Parameters.Add("@active", SqlDbType.Bit);

                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@suppid"].Value = cbbSupp.SelectedValue;
                cmd.Parameters["@catid"].Value = cbbCat.SelectedValue;
                cmd.Parameters["@quantity"].Value = txtQuantity.Text;
                cmd.Parameters["@price"].Value = txtPrice.Text;
                cmd.Parameters["@stock"].Value = txtStock.Text;
                cmd.Parameters["@order"].Value = txtOrder.Text;
                cmd.Parameters["@lever"].Value = txtRenderLv.Text;
                cmd.Parameters["@active"].Value = rbActive.Checked == true ? true : false;

                conn.Open();

                int numRow = cmd.ExecuteNonQuery();

                if (numRow > 0)
                {
                    MessageBox.Show("Successfully adding new Product", "Message");
                    DialogResult = DialogResult.OK;
                    this.ResetText();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Adding customer failed");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error");
            }
        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadSupplier();
        }

        private void LoadCategory()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT CatID, CatName FROM Categories";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            cbbCat.DataSource = dt;
            cbbCat.DisplayMember = "CatName";
            cbbCat.ValueMember = "CatID";
        }
        private void LoadSupplier()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT SupplierID, CompanyName FROM Suppliers";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            cbbSupp.DataSource = dt;
            cbbSupp.DisplayMember = "CompanyName";
            cbbSupp.ValueMember = "SupplierID";
        }
    }
}
