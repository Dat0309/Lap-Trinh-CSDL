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

namespace ABC_Restaurant.Employees
{
    public partial class ListEmployFrm : Form
    {
        private DataTable table;
        public ListEmployFrm()
        {
            InitializeComponent();
        }
        public void initUI()
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Employees";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            table = new DataTable();

            conn.Open();

            adapter.Fill(table);
            dgvEmploy.DataSource = table;
            dgvEmploy.Columns[0].ReadOnly = true;

            conn.Close();
        }

        private void dgvEmploy_DoubleClick(object sender, EventArgs e)
        {
            var EmployID = dgvEmploy.SelectedRows[0].Cells[0].Value.ToString();
            TrackOperation frm = new TrackOperation();
            frm.initUI(EmployID);
            frm.ShowDialog(this);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (table == null) return;

            string filterExpression = String.Format("LastName like '%{0}%' OR Phone like '%{0}%' OR Address like '%{0}%'", txtSearch.Text);
            string sortExpression = "LastName";
            DataViewRowState dataViewRowState = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(table, filterExpression, sortExpression, dataViewRowState);

            dgvEmploy.DataSource = foodView;
        }
    }
}
