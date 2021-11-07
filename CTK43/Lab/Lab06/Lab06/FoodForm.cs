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
    public partial class frmFood : Form
    {
        int categoryID;
        public frmFood()
        {
            InitializeComponent();
        }
        public void LoadFood(int categoryID)
        {
            this.categoryID = categoryID;
            string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComd = sqlConn.CreateCommand();

            sqlComd.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

            sqlConn.Open();

            string catName = sqlComd.ExecuteScalar().ToString();
            this.Text = "Danh dach cac mon an thuoc nhom: " + catName;

            sqlComd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

            SqlDataAdapter da = new SqlDataAdapter(sqlComd);
            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            dgvFood.DataSource = dt;

            sqlConn.Close();
            sqlConn.Dispose();
            da.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComd = sqlConn.CreateCommand();

            sqlConn.Open();

            for (int i = 0; i< dgvFood.Rows.Count - 1; i++)
            {
                int id = (int)dgvFood.Rows[i].Cells["ID"].Value;
                sqlComd.CommandText = "SELECT * FROM Food WHERE ID = " + id;
                var checkID = sqlComd.ExecuteScalar();

                if(checkID == null)
                {
                    string query = string.Format(" INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes) " +
                    "VALUES (N'{0}', N'{1}', {2}, {3}, N'{4}')",
                    dgvFood.Rows[i].Cells["Name"].Value,
                    dgvFood.Rows[i].Cells["Unit"].Value,
                    categoryID,
                    dgvFood.Rows[i].Cells["Price"].Value,
                    dgvFood.Rows[i].Cells["Notes"].Value.ToString());
                    sqlComd.CommandText = query;
                    sqlComd.ExecuteNonQuery();
                    MessageBox.Show("Them moi thanh cong");
                }
                else
                {
                    string query = string.Format(" UPDATE Food SET Name = N'{0}', Unit = N'{1}', FoodCategoryID = {2}, Price = {3}, Notes = N'{4}' WHERE ID = {5}",
                    dgvFood.Rows[i].Cells["Name"].Value,
                    dgvFood.Rows[i].Cells["Unit"].Value,
                    categoryID,
                    dgvFood.Rows[i].Cells["Price"].Value,
                    dgvFood.Rows[i].Cells["Notes"].Value.ToString(), 
                    id.ToString());
                    sqlComd.CommandText = query;
                    sqlComd.ExecuteNonQuery();
                    MessageBox.Show("Cap nhat thanh cong");
                }
            }

            sqlConn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0) return;
            var rowSelect = dgvFood.SelectedRows[0];
            string foodID = rowSelect.Cells[0].Value.ToString();

            string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComd = sqlConn.CreateCommand();

            string query = "DELETE FROM Food WHERE ID = " + foodID;

            sqlConn.Open();
            sqlComd.CommandText = "DELETE FROM BillDetails WHERE FoodID = " + foodID;
            sqlComd.ExecuteNonQuery();
               
            sqlComd.CommandText = query;
            int numOfRowsEffected = sqlComd.ExecuteNonQuery();
            if(numOfRowsEffected == 1)
            {
                dgvFood.Rows.Remove(rowSelect);
                MessageBox.Show("Da xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Da xay ra loi");
                return;
            }

            sqlConn.Close();
        }
    }
}
