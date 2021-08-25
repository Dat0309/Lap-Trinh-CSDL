using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbkMauchu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbkMauchu.Checked)
                this.btn1.ForeColor = Color.Red;
            else
                this.btn1.ForeColor = Color.Black;
        }

        private void cbkMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbkMauNen.Checked)
                this.btn1.BackColor = Color.LightBlue;
            else
                this.btn1.BackColor = this.btn2.BackColor;
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
                this.btn2.FlatStyle = FlatStyle.Flat;
            else
                this.btn2.FlatStyle = FlatStyle.Popup;
        }

        private void rdPopup_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdPopup.Checked)
                this.btn2.FlatStyle = FlatStyle.Popup;
            else
                this.btn2.FlatStyle = FlatStyle.Flat;
        }
    }
}
