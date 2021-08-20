using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex48
{
    public partial class Demo_CBB : Form
    {
        public Demo_CBB()
        {
            InitializeComponent();
        }


        private void Demo_CBB_Load_1(object sender, EventArgs e)
        {
            string[] data = { "Android", "C-Sharp", "Java", "Python" };
            this.cbb_Leaguage.DataSource = data;
        }

        private void cbb_Leaguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cbb_Leaguage.SelectedItem.ToString());
        }
    }
}
