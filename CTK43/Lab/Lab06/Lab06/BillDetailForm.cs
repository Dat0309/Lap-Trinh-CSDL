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
    public partial class BillDetailForm : Form
    {
        int ID;
        public BillDetailForm()
        {
            InitializeComponent();
        }

        public void LoadBillDetail(int id)
        {
            this.ID = id;

            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT Name FROM Bills WHERE ID = " + id;
            connection.Open();
            string billName = command.ExecuteScalar().ToString();
            this.Text = billName +" "+ id;

            string query = string.Format(
                " SELECT Name, Unit, Price, Quantity, Price * Quantity as Total FROM BillDetails" +
                " JOIN Food ON BillDetails.FoodID = Food.ID" +
                " WHERE BillDetails.InvoiceID = {0}",id);
            command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable("Food");
            adapter.Fill(dt);

            dgvBillDetails.DataSource = dt;
            dgvBillDetails.Columns[0].ReadOnly = true;

            connection.Dispose();
            adapter.Dispose();
        }
    }
}
