using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void frm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepSkyBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dang nhap thanh cong");

        }

       
    }
}
