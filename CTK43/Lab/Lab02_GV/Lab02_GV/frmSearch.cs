using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_GV
{
    public partial class frmSearch : Form
    {
        QuanLyGiaoVien qlgv = new QuanLyGiaoVien();

        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string name = txtKey.Text;
            var gv = qlgv.Tim(name, KieuTim.TheoHoTen);
            if(gv is null)
            {
                MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var frmTBGiaoVien = new formTBGiaoVien();
                frmTBGiaoVien.SetText(gv.ToString());
                frmTBGiaoVien.ShowDialog();
            }
        }

        private void btnSearchCode_Click(object sender, EventArgs e)
        {       

        }

        private void btnSearchSDT_Click(object sender, EventArgs e)
        {

        }
    }
}
