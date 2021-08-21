using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex72
{
    public partial class DemoTabPage : Form
    {
        public DemoTabPage()
        {
            InitializeComponent();
        }

        private void DemoTabPage_Load(object sender, EventArgs e)
        {
            string[] monHoc = {"Lap trinh CSDL", "Lap trinhf Android","Lap trinh web", "Cong nghe phan mem"};
            this.listBox1.DataSource = monHoc;
            this.cbbGV.DataSource = monHoc;
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            string tenSV = txtSVName.Text;
            string maSV = txtSVID.Text;
            string khoa = cbbSV.SelectedItem.ToString();

            MessageBox.Show(String.Format("Ten sinh vien : {0}, Ma so: {1}, Khoa: {2}", tenSV, maSV, khoa));
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            string tenSV = txtGVName.Text;
            string maSV = txtGVID.Text;
            string khoa = cbbGV.SelectedItem.ToString();

            MessageBox.Show(String.Format("Ten sinh vien : {0}, Ma so: {1}, Khoa: {2}", tenSV, maSV, khoa));
        }
    }
}
