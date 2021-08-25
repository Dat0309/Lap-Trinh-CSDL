using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo18_08_2021
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var loginName = txtLoginName.Text;
			var password = txtPassword.Text;

			if (loginName.CompareTo("a") == 0 && password.CompareTo("1") == 0)
			{
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				lblMessage.Text = "Sai tên đăng nhập hoặc mật khẩu.";
			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
