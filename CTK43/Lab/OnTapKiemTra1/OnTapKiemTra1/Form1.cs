using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnTapKiemTra1.Data;
using OnTapKiemTra1.Model;
using OnTapKiemTra1.IO;

namespace OnTapKiemTra1
{
    public partial class Form1 : Form
    {
        private QLSV qlsv;
        string fileName;
        private readonly NewRepo newRepo;
        public Form1()
        {
            InitializeComponent();
            fileName = "Data\\data.txt";
            List<Khoa> dsKhoa = new List<Khoa>();
            qlsv = new QLSV(Context.getInstance(new TextData(fileName)));
            newRepo = NewRepo.getInstance(qlsv);
        }

        #region Cac ham xu ly 
        private void ThemSV(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.mssv);
            item.SubItems.Add(sv.ho);
            item.SubItems.Add(sv.ten);
            item.SubItems.Add(sv.gioiTinh == true?"Nam":"Nu");
            item.SubItems.Add(sv.ngaySinh.ToShortDateString());
            item.SubItems.Add(sv.sdt);
            item.SubItems.Add(sv.lop);
            item.SubItems.Add(sv.khoa);

            lvSV.Items.Add(item);
        }

        private void LoadSVToListView(List<SinhVien> danhsach)
        {
            lvSV.Items.Clear();
            foreach (SinhVien sv in danhsach)
                ThemSV(sv);
        }

        private SinhVien GetSVLV(ListViewItem item)
        {  
            return new SinhVien() { 
                mssv = item.SubItems[0].Text,
                ho = item.SubItems[1].Text,
                ten = item.SubItems[2].Text,
                gioiTinh = item.SubItems[3].Text == "Nam" ? true : false,
                ngaySinh = DateTime.Parse(item.SubItems[4].Text),
                sdt = item.SubItems[5].Text,
                lop = item.SubItems[6].Text,
                khoa = item.SubItems[7].Text
            };
        }

        #endregion
        private void ShowFeedOnTreeView(List<Khoa> dsKhoa)
        {
            tvKhoa.Nodes.Clear();
            foreach (var k in dsKhoa)
            {
                var khoaNode = tvKhoa.Nodes.Add(k.Name);
                foreach (var l in k.Lop)
                {
                    khoaNode.Nodes.Add(l.Name);
                }
            }
            tvKhoa.ExpandAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSVToListView(qlsv.dssv);
            ShowFeedOnTreeView(newRepo.GetKhoa());
        }
    }
}
