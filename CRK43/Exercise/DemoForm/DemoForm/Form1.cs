using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form1 : Form
    {
        private List<MonHoc> listHocPhan;
        frmKetQuaDangKy kq = new frmKetQuaDangKy();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listHocPhan = new List<MonHoc>();
            NhapTuFile("DSHP.txt");
            //Random r = new Random();
            //for (int i = 1; i < 40; i++)
            //{
            //    MonHoc hocPhan = new MonHoc();

            //    hocPhan.MaHP = i;
            //    hocPhan.TenHP = $"Học phần {i}";
            //    hocPhan.LoaiHP = r.Next(0, 2);
            //    hocPhan.STC = r.Next(2, 5);
            //    hocPhan.Nam = r.Next(1, 5);

            //    listHocPhan.Add(hocPhan);
            //}

            var Course = new[] { flp1, flp2, flp3, flp4 };
            foreach (var item in listHocPhan)
            {
                
                Button btn = new Button();
                btn.Text = item.TenHP;
                btn.BackColor = item.LoaiHP == 0 ? Color.ForestGreen : Color.IndianRed;
                btn.Height = 40;
                btn.Width = 80;
                ttHocPhan.SetToolTip(btn, $" {item.TenHP}, Số tín chỉ {item.STC}, Thuộc tính {(item.LoaiHP == 0 ? "Tự chọn" : "Bắt buộc")}, Năm {item.Nam}");


                Course[item.Nam -1].Controls.Add(btn);
            }

            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            foreach (var item in listHocPhan)
            {
                ListViewItem items = new ListViewItem(item.MaHP.ToString());
                items.SubItems.Add(item.TenHP);
                items.SubItems.Add(item.LoaiHP == 0 ? "Tự chọn" : "Bắt buộc");
                items.SubItems.Add(item.STC.ToString());
                items.SubItems.Add($"Năm {item.Nam}");

                lvDanhSach.Items.Add(items);
            }
        }

        private void NhapTuFile(string file)
        {
            StreamReader sr = new StreamReader(file);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(',');
                listHocPhan.Add(new MonHoc(str[0], str[1], int.Parse(str[2]), int.Parse(str[3]), int.Parse(str[4])));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var itemSelect = lvDanhSach.SelectedIndices;
                    foreach (int item in itemSelect)
                    {
                        ListViewItem items = new ListViewItem(listHocPhan[item].MaHP.ToString());
                        items.SubItems.Add(listHocPhan[item].TenHP);
                        items.SubItems.Add(listHocPhan[item].LoaiHP == 0 ? "Tự chọn" : "Bắt buộc");
                        items.SubItems.Add(listHocPhan[item].STC.ToString());
                        items.SubItems.Add($"Năm {listHocPhan[item].Nam}");

                        lvKetQua.Items.Add(items);
                    }
            }
            catch
            {
                //var listCheckedItem = lvDanhSach.CheckedIndices;
                //foreach (int item in listCheckedItem)
                //{
                //    ListViewItem items = new ListViewItem(listHocPhan[item].MaHP.ToString());
                //    items.SubItems.Add(listHocPhan[item].TenHP);
                //    items.SubItems.Add(listHocPhan[item].LoaiHP == 0 ? "Tự chọn" : "Bắt buộc");
                //    items.SubItems.Add(listHocPhan[item].STC.ToString());
                //    items.SubItems.Add($"Năm {listHocPhan[item].Nam}");

                //    lvKetQua.Items.Add(items);
                //}
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lvKetQua.SelectedItems.Count - 1;
            while(i >= 0)
            {
                lvKetQua.Items.RemoveAt(lvKetQua.SelectedIndices[i]);
                i--;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsmiDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                var itemSelect = lvDanhSach.SelectedIndices;
                foreach (int item in itemSelect)
                {
                    ListViewItem items = new ListViewItem(listHocPhan[item].MaHP.ToString());
                    items.SubItems.Add(listHocPhan[item].TenHP);
                    items.SubItems.Add(listHocPhan[item].LoaiHP == 0 ? "Tự chọn" : "Bắt buộc");
                    items.SubItems.Add(listHocPhan[item].STC.ToString());
                    items.SubItems.Add($"Năm {listHocPhan[item].Nam}");

                    lvKetQua.Items.Add(items);
                }
            }
            catch {
                //var listCheckedItem = lvDanhSach.CheckedIndices;
                //foreach (int item in listCheckedItem)
                //{
                //    ListViewItem items = new ListViewItem(listHocPhan[item].MaHP.ToString());
                //    items.SubItems.Add(listHocPhan[item].TenHP);
                //    items.SubItems.Add(listHocPhan[item].LoaiHP == 0 ? "Tự chọn" : "Bắt buộc");
                //    items.SubItems.Add(listHocPhan[item].STC.ToString());
                //    items.SubItems.Add($"Năm {listHocPhan[item].Nam}");

                //    lvKetQua.Items.Add(items);
                //}
            }
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            int i = lvKetQua.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lvKetQua.Items.RemoveAt(lvKetQua.SelectedIndices[i]);
                i--;
            }
        }

        private void tsmiShowResult_Click(object sender, EventArgs e)
        { 
            frmKetQuaDangKy KetQua = new frmKetQuaDangKy();
            KetQua.ShowDialog();   
            
        }
    }
}
