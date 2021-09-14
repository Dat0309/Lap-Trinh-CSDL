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
                    Image img = frm.pbHinh.Image;
                    img.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                }
                catch
                {
                    MessageBox.Show("Lỗi lưu file!");
                }
            }
        }
    }
}
