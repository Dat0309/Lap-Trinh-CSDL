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

namespace Lab07
{
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }
        public void LoadRole(string name)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "Select * from Role";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable("Role");

            DataGridViewCheckBoxColumn checkCol = new DataGridViewCheckBoxColumn();
            checkCol.Name = "Role";
            checkCol.HeaderText = "Role";
            checkCol.Width = 50;
            checkCol.ReadOnly = true;
            checkCol.FillWeight = 10;

            conn.Open();

            adapter.Fill(table);

            dgvRole.Columns.Add(checkCol);
            dgvRole.DataSource = table;
            for (int i = 0; i < dgvRole.Rows.Count - 1; i++)
            {
                dgvRole[0,i].Value = true;
            }

            // Prevent user to edit ID
            dgvRole.Columns[1].ReadOnly = true;

            conn.Close();
        }
    }
}
