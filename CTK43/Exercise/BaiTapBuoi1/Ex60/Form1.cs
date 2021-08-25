using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex60
{
    public partial class DemoCheckListBox : Form
    {

        string s = "";
        public DemoCheckListBox()
        {
            InitializeComponent();
        }

        private void DemoCheckListBox_Load(object sender, EventArgs e)
        {
            string[] monHoc = { "Lập trình cơ sở dữ liệu", "Phát triển ứng dụng di động", "Phát triển ứng dụng web", "Công nghệ phần mềm", "Tư tưởng HCM" };
            foreach (object item in monHoc)
            {
                this.clbDanhSach.Items.Add(item);
            }
        }

        private void clbDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            items = this.clbDanhSach.CheckedItems;

            foreach (object item in items)
            {
                s += item.ToString() + "\n";

            } 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Danh sach mon hoc: " + s);
        }
    }
}
