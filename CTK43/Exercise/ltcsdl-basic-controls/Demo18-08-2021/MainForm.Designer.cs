namespace Demo18_08_2021
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.flpFloorOne = new System.Windows.Forms.FlowLayoutPanel();
			this.ttFloor = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.flpFloorTwo = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.flpFloorThree = new System.Windows.Forms.FlowLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpFloorOne
			// 
			this.flpFloorOne.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpFloorOne.Location = new System.Drawing.Point(3, 16);
			this.flpFloorOne.Name = "flpFloorOne";
			this.flpFloorOne.Size = new System.Drawing.Size(358, 164);
			this.flpFloorOne.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.flpFloorOne);
			this.groupBox1.Location = new System.Drawing.Point(12, 36);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(364, 183);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tầng 1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.flpFloorTwo);
			this.groupBox2.Location = new System.Drawing.Point(12, 225);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(364, 183);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tầng 2";
			// 
			// flpFloorTwo
			// 
			this.flpFloorTwo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpFloorTwo.Location = new System.Drawing.Point(3, 16);
			this.flpFloorTwo.Name = "flpFloorTwo";
			this.flpFloorTwo.Size = new System.Drawing.Size(358, 164);
			this.flpFloorTwo.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.flpFloorThree);
			this.groupBox3.Location = new System.Drawing.Point(12, 414);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(364, 183);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tầng 3";
			// 
			// flpFloorThree
			// 
			this.flpFloorThree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpFloorThree.Location = new System.Drawing.Point(3, 16);
			this.flpFloorThree.Name = "flpFloorThree";
			this.flpFloorThree.Size = new System.Drawing.Size(358, 164);
			this.flpFloorThree.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.tsmiAccount});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmiAdmin
			// 
			this.tsmiAdmin.Name = "tsmiAdmin";
			this.tsmiAdmin.Size = new System.Drawing.Size(60, 20);
			this.tsmiAdmin.Text = "Quản lý";
			this.tsmiAdmin.Click += new System.EventHandler(this.tsmiAdmin_Click);
			// 
			// tsmiAccount
			// 
			this.tsmiAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
			this.tsmiAccount.Name = "tsmiAccount";
			this.tsmiAccount.Size = new System.Drawing.Size(70, 20);
			this.tsmiAccount.Text = "Tài khoản";
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
			// 
			// đổiMậtKhẩuToolStripMenuItem
			// 
			this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
			this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpFloorOne;
		private System.Windows.Forms.ToolTip ttFloor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.FlowLayoutPanel flpFloorTwo;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.FlowLayoutPanel flpFloorThree;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
		private System.Windows.Forms.ToolStripMenuItem tsmiAccount;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
	}
}

