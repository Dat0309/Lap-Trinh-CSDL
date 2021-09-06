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
    public partial class formTBGiaoVien : Form
    {
        public formTBGiaoVien()
        {
            InitializeComponent();
        }
        public void SetText(string s)
        {
            this.lbThongBao.Text = s;
        }
    }
}
