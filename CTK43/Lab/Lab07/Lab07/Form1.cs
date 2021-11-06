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

namespace Lab07
{
    public partial class Form1 : Form
    {
        private DataTable foodTb;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadCategory();
        }
        private void LoadCategory()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Food Where FoodCategoryID = @categoryId";

            cmd.Parameters.Add("@categoryId", SqlDbType.Int);
            if(cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView? rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTb = new DataTable();

            conn.Open();

            adapter.Fill(foodTb);

            conn.Close();
            conn.Dispose();

            dgvFoodList.DataSource = foodTb;

            dgvFoodList.Columns[0].ReadOnly = true;

            lblCatName.Text = cbbCategory.Text;
            lblQuantity.Text = foodTb.Rows.Count.ToString();
        }

        private void tsmCalculateQuantuty_Click(object sender, EventArgs e)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

            if(dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView? rowView = selectedRow.DataBoundItem as DataRowView;

                cmd.Parameters.Add("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];

                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                conn.Open();

                cmd.ExecuteNonQuery();

                var result = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + (result == ""? 0:result) + " " + rowView["Unit"]);

                conn.Close();

            }
            cmd.Dispose();
            conn.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodinfoForrm frmFood = new FoodinfoForrm();
            frmFood.loadAdd();
            frmFood.FormClosed += new FormClosedEventHandler(frmFood_FormClosed);
            frmFood.Show(this);
        }

        private void frmFood_FormClosed(object? sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if(dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                var rowView = selectedRow.DataBoundItem as DataRowView;
                FoodinfoForrm frmFood = new FoodinfoForrm();
                frmFood.loadUpdate();
                frmFood.FormClosed += new FormClosedEventHandler(frmFood_FormClosed);
                frmFood.Show(this);
                frmFood.DisplayFoodInfo(rowView);
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTb == null) return;

            string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState dataViewRowState = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTb, filterExpression, sortExpression, dataViewRowState);

            dgvFoodList.DataSource = foodView;
        }

        private void bntBills_Click(object sender, EventArgs e)
        {
            OrderForm frm = new OrderForm();
            frm.ShowDialog(this);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountForrm frm = new AccountForrm();
            frm.ShowDialog(this);
        }
    }
}