using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab02_GV
{
    public partial class frmGiaoVien : Form
    {
        QuanLyGiaoVien qlgv = new QuanLyGiaoVien();
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void bttnLuu_Click(object sender, EventArgs e)
        {
            formTBGiaoVien frm = new formTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }

        public GiaoVien GetGiaoVien()
        {
            string gt = rdNam.Checked ? "Nam" : "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cbbMS.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtGmail.Text;
            gv.SoDT = this.mtxtSDT.Text;

            List<string> ngoaiNgu = new List<string>();
            for (int i = 0; i < clbNgoaiNgu.Items.Count - 1; i++)
                if (clbNgoaiNgu.GetItemChecked(i))
                    ngoaiNgu.Add(clbNgoaiNgu.Items[i].ToString());
            gv.NgoaiNgu = ngoaiNgu;
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in lbxMonHocGV.Items)
            {
                mh.Them(new MonHoc(ob.ToString()));
            }
            gv.dsMonHoc = mh;

            return gv;
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienHe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.llbLienHe.Links.Add(0, lienHe.Length, lienHe);
            this.cbbMS.SelectedItem = this.cbbMS.Items[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbxDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbxMonHocGV.Items.Add(lbxDanhSachMH.SelectedItems[i]);
                this.lbxDanhSachMH.Items.Remove(lbxDanhSachMH.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbxMonHocGV.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbxDanhSachMH.Items.Add(lbxMonHocGV.SelectedItems[i]);
                this.lbxMonHocGV.Items.Remove(lbxMonHocGV.SelectedItems[i]);
                i--;
            }
        }

        private void llbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        private void Reset()
        {
            this.cbbMS.Text = "";
            this.txtHoTen.Text = "";
            this.txtGmail.Text = "";
            this.mtxtSDT.Text = "";
            this.rdNam.Checked = true;

            for(int i=0;i<clbNgoaiNgu.Items.Count - 1; i++)
            {
                clbNgoaiNgu.SetItemChecked(i, false);
            }
            foreach (object ob in lbxMonHocGV.Items)
            {
                this.lbxDanhSachMH.Items.Add(ob);
            }
            this.lbxMonHocGV.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            qlgv.Them(GetGiaoVien());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frm = new frmSearch();
            frm.ShowDialog();
        }
    }
}
