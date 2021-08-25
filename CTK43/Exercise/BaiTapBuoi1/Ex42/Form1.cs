using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex42
{
    public partial class Submit_ex : Form
    {
        public Submit_ex()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string user = this.txtUser.Text;
            string pass = this.txtPass.Text;
            string des = this.txtDescription.Text;

            MessageBox.Show(String.Format("User: {0}, Password: {1}, Description: {2}",user,pass,des));
        }
    }
}
