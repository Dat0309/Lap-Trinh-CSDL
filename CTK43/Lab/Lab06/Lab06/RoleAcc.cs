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
    public partial class RoleAcc : Form
    {
        public RoleAcc()
        {
            InitializeComponent();
        }
        public void LoadRole(string name)
        {
            string connectionString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT a.AccountName, r.RoleName " +
                " from Role r, RoleAccount ra, Account a" +
                " Where a.AccountName = ra.AccountName and r.ID = ra.RoleID and a.AccountName = '" + name +"'";

            connection.Open();

            this.Text = "Danh sách role cua tai khoan "+name;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable("Role");
            adapter.Fill(table);

            dgvRole.DataSource = table;

            // Prevent user to edit ID
            dgvRole.Columns[0].ReadOnly = true;
            dgvRole.Columns[0].HeaderText = "Tài khoản";
            dgvRole.Columns[1].HeaderText = "Quyền";
            connection.Close();
        }
    }
}
