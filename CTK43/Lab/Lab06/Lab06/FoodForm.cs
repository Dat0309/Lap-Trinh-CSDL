using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Lab06
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }
        public void LoadFood(int categoryID)
        {
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
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
    }
}
