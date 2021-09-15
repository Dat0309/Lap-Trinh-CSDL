using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Lab04_Demo
{
    public partial class frmPictureView : Form
    {
        int count = 0;
        public frmPictureView()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                frmPicture frm = new frmPicture(openFileDialog1.FileName);
                frm.MdiParent = this;
                count++;
                frm.Text = "Picture -" + count + "-" + openFileDialog1.FileName;
                frm.Show();
            }
            this.toolStripStatusLabel1.Text = "Tổng số Form con:" + count.ToString();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.saveFileDialog1.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                frmPicture frm = this.ActiveMdiChild as frmPicture;
                try
                {
                    Image img = frm.pbPic.Image;
                    img.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                }
                catch
                {
                    MessageBox.Show("Lỗi lưu file!");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = this.staToolStripMenuItem.Checked;
            if (check) this.statusStrip1.Visible = true;
            else this.statusStrip1.Visible = false;
        }

        private void toolStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool check = this.toolStripToolStripMenuItem.Checked;
            if (check) this.toolStrip1.Visible = true;
            else this.toolStrip1.Visible = false;
        }

        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ararngeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void arrangeVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void maximizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.WindowState = FormWindowState.Minimized;
            }
        }

        private void tsZoomOut_Click(object sender, EventArgs e)
        {
            frmPicture frm = this.ActiveMdiChild as frmPicture;
            frm.tsmiZoomOut_Click(sender, e);
        }

        private void tsZoomIn_Click(object sender, EventArgs e)
        {
            frmPicture frm = this.ActiveMdiChild as frmPicture;
            frm.tsmiZoomIn_Click(sender, e);
        }

        private void tsOpenPaint_Click(object sender, EventArgs e)
        {
            frmPicture frm = this.ActiveMdiChild as frmPicture;
            try
            {
                frm.tsmiEdit_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Xin hãy mở ảnh!");
            }
        }
    }
}
