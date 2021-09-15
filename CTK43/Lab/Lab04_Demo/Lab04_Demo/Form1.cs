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

namespace Lab04_Demo
{
    public partial class frmPicture : Form
    {
        public PictureBox pbPic;
        bool ctrl;
        Point p = new Point();
        public frmPicture()
        {
            InitializeComponent();
        }
        public frmPicture(string name) : this()
        {
            this.pbHinh.ImageLocation = name;
            this.toolStripStatusLabel1.Text = name;
            pbPic = this.pbHinh;
        }

        private void frmPicture_Load(object sender, EventArgs e)
        {
            p = this.pbHinh.Location;
            ctrl = false;

            this.MouseWheel += FrmPicture_MouseWheel;
            this.KeyDown += frmPicture_KeyDown;
            this.KeyUp += frmPicture_KeyUp;
        }

        private void FrmPicture_MouseWheel(object sender, MouseEventArgs e)
        {
            if (ctrl)
            {
                int h = (int)(this.pbHinh.Image.Width * 0.05);
                int v = (int)(this.pbHinh.Image.Height * 0.05);
                if(e.Delta > 0)
                {
                    this.pbHinh.Width += h;
                    this.pbHinh.Height += v;
                }
                else
                {
                    this.pbHinh.Width -= h;
                    this.pbHinh.Height -= v;
                }
            }
            else
            {
                if(e.Delta >0 && this.vScrollBar1.Value > 5)
                {
                    this.vScrollBar1.Value -= 5;
                }
                if(e.Delta <0 && this.vScrollBar1.Value < this.vScrollBar1.Maximum - 5)
                {
                    this.vScrollBar1.Value += 5;
                }
                pbHinh.Location = new Point(p.X, p.Y - this.vScrollBar1.Value);
            }
        }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            string title = "";
            if (dlg == DialogResult.OK)
            {
                title = openFileDialog1.FileName;
                this.Text = title;
                this.pbHinh.ImageLocation = openFileDialog1.FileName;
            }
        }

        public void tsmiZoomOut_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width += 50;
            this.pbHinh.Height += 50;
        }

        public void tsmiZoomIn_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width -= 50;
            this.pbHinh.Height -= 50;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X, p.Y - e.NewValue);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X - e.NewValue, p.Y);
        }

        public void tsmiEdit_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint", this.pbHinh.ImageLocation);
        }

        private void frmPicture_KeyUp(object sender, KeyEventArgs e)
        {
            this.ctrl = e.Control;
        }

        private void frmPicture_KeyDown(object sender, KeyEventArgs e)
        {
            this.ctrl = e.Control;
        }
    }
}
