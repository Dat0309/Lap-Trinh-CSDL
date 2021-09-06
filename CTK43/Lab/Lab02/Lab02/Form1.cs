using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (cbTinHocA.Checked) sum += int.Parse(lbTHA.Text.Split('.')[0]);
            if (cbTinHocB.Checked) sum += int.Parse(lbTHB.Text.Split('.')[0]);
            if (cbTiengAnhA.Checked) sum += int.Parse(lbTAA.Text.Split('.')[0]);
            if (cbTiengAnhB.Checked) sum += int.Parse(lbTAB.Text.Split('.')[0]);
            this.txtTongTien.Text = sum + ".000 đồng";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReSet();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReSet()
        {
            this.cbbMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.txtTongTien.Text = "";
            this.dtpNgay.Value = DateTime.Now;
            rdNam.Checked = true;
            cbTiengAnhA.Checked = false;
            cbTiengAnhB.Checked = false;
            cbTinHocA.Checked = false;
            cbTinHocB.Checked = false;
        }

        
    }
}
