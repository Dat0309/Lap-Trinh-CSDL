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

        public frmSearch(QuanLyGiaoVien qlgv) : this()
        {
            this.qlgv = qlgv;
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTen.Checked)
            {
                lbTimKiem.Text = rdTen.Text;
                txtKey.Text = "";
            }
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMa.Checked)
            {
                lbTimKiem.Text = rdMa.Text;
                txtKey.Text = "";
            }
        }

        private void rdSDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSDT.Checked)
            {
                lbTimKiem.Text = rdSDT.Text;
                txtKey.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var kieu = KieuTim.TheoHoTen;
            if (rdMa.Checked)
            {
                kieu = KieuTim.TheoMa;
            }
            else if (rdTen.Checked)
            {
                kieu = KieuTim.TheoHoTen;
            }
            else if (rdSDT.Checked)
            {
                kieu = KieuTim.TheoSDT;
            }

            var gv = qlgv.Tim(txtKey.Text, kieu);
            if (gv is null)
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
    }
}
