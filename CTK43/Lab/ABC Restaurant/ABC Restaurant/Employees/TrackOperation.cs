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
    public partial class TrackOperation : Form
    {
        public TrackOperation()
        {
            InitializeComponent();
        }
        public void initUI(string employID)
        {
            string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Orders WHERE EmployeeID = @id";
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = employID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);
            dgvTrack.DataSource = dt;
            dgvTrack.Columns[0].ReadOnly = true;

            dgvTrack.Columns[0].HeaderText = "Mã Hoá đơn";
            dgvTrack.Columns[1].HeaderText = "Mã khách hàng";
            dgvTrack.Columns[2].HeaderText = "Mã Nhân viên";
            dgvTrack.Columns[3].HeaderText = "Ngày nhập đơn";
            dgvTrack.Columns[4].HeaderText = "Ngày yêu cầu";
            dgvTrack.Columns[5].HeaderText = "Ngày giao hàng";
            dgvTrack.Columns[6].HeaderText = "Vận chuyển";
            dgvTrack.Columns[7].HeaderText = "Freight";
            dgvTrack.Columns[8].HeaderText = "Tên người vận chuyển";
            dgvTrack.Columns[9].HeaderText = "Địa chỉ";
            dgvTrack.Columns[10].HeaderText = "Thành phố";
            dgvTrack.Columns[11].HeaderText = "Khu vực";
            dgvTrack.Columns[12].HeaderText = "Mã bưu điện";
            dgvTrack.Columns[13].HeaderText = "Quốc gia";

            conn.Close();
        }
    }
}
