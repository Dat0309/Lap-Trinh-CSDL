using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex52
{
    public partial class listBox : Form
    {
        
        public listBox()
        {
            InitializeComponent();
        }

        private void listBox_Load(object sender, EventArgs e)
        {
            string[] data = { "Đinh Trọng Đạt", "Mai Ngọc Trí", "Đào Xuân Hải", "Trần Minh Cảnh" };
            this.listSinhVien.DataSource = data;
        }


        private void btnChon_Click(object sender, EventArgs e)
        {
            int itemSelect = listSinhVien.SelectedItems.Count - 1;
            for(int i = itemSelect; i>=0; i--)
            {
                listDanhSach.Items.Add(listSinhVien.SelectedItems[i]);
                listSinhVien.Items.Remove(listSinhVien.SelectedIndices[i]);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = listDanhSach.SelectedItems.Count - 1;
            while (i >= 0)
            {
                listDanhSach.Items.RemoveAt(listDanhSach.SelectedIndices[i]);
                i--;
            }
        }

        private void listSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
