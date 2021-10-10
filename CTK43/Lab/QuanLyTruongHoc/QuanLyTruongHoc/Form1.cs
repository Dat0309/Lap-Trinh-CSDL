using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTruongHoc.Model;
using QuanLyTruongHoc.Data;

namespace QuanLyTruongHoc
{
    public partial class Form1 : Form
    {
        private QLKhoa qLKhoa;
        string fileName;
        public Form1()
        {
            InitializeComponent();
            fileName = "Data\\data.txt";
            List<Khoa> dsKhoa = new List<Khoa>();
            qLKhoa = new QLKhoa(Context.getInstance(new TextDataStorage(fileName)));
            
        }

        #region ham xu ly
        private void ThemSV(Khoa k)
        {
            foreach (var l in k.listLop)
            {
                foreach (var sv in l.listSinhVien)
                {
                    ListViewItem item = new ListViewItem(sv.StudentID);
                    item.SubItems.Add(sv.FirstName);
                    item.SubItems.Add(sv.LastName);
                    item.SubItems.Add(sv.Gender == true ? "Nam" : "Nu");
                    item.SubItems.Add(sv.BirthDay.ToShortDateString());
                    item.SubItems.Add(sv.PhoneNumber);
                    item.SubItems.Add(l.ClassName);
                    item.SubItems.Add(k.Name);
                    item.SubItems.Add(sv.Address);

                    lvSV.Items.Add(item);
                }
            }
        }

        private void LoadSVToListView(List<Khoa> danhsach)
        {
            lvSV.Items.Clear();
            foreach (Khoa k in danhsach)
                ThemSV(k);
        }

        private Khoa GetKhoaLV(ListViewItem item)
        {
            List<Lop> dsLop = new List<Lop>();
            dsLop.Add(new Lop() 
            { 
                ClassName = item.SubItems[6].Text, 
                listSinhVien = GetSVLV(item)
             });
            return new Khoa()
            {
                Name = item.SubItems[7].Text,
                listLop = dsLop
            };
        }
        private List<SinhVien> GetSVLV(ListViewItem item)
        {
            List<SinhVien> dskq = new List<SinhVien>();
            dskq.Add(new SinhVien(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text == "Nam" ? true : false,
                        DateTime.Parse(item.SubItems[4].Text), item.SubItems[5].Text, item.SubItems[8].Text));
            return dskq;
        }

        private void ShowFeedOnTreeView(List<Khoa> dsKhoa)
        {
            tvKhoa.Nodes.Clear();
            foreach (var k in GetDSKhoa(dsKhoa))
            {
                var khoaNode = tvKhoa.Nodes.Add(k);
                foreach (var l in GetDSLop(k))
                {
                    khoaNode.Nodes.Add(l);
                }
            }
            tvKhoa.ExpandAll();
        }

        private List<string> GetDSKhoa(List<Khoa> dsKhoa)
        {
            List<string> tenKhoa = new List<string>();
            foreach (var item in dsKhoa)
            {
                if (!tenKhoa.Contains(item.Name))
                    tenKhoa.Add(item.Name);
            }
            return tenKhoa;
        }
        private List<string> GetDSLop(string tenKhoa)
        {
            List<string> dsLop = new List<string>();
            foreach (var k in qLKhoa.dsk)
                foreach(var l in k.listLop)
                    if (k.Name.CompareTo(tenKhoa) == 0)
                        if (!dsLop.Contains(l.ClassName))
                            dsLop.Add(l.ClassName);
            return dsLop;
        }

        private int SoSanhTheoKhoa(object obj1, object obj2)
        {
            return (obj2 as Khoa).Name.CompareTo(obj1.ToString());
        }
        private int SoSanhTheoLop(object obj1, object obj2)
        {
            return (obj2 as Lop).ClassName.CompareTo(obj1.ToString());
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.StudentID.CompareTo(obj1);
        }
        private int SoSanhTheoTen(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.LastName.CompareTo(obj1);
        }

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSVToListView(qLKhoa.dsk);
            ShowFeedOnTreeView(qLKhoa.dsk);
        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<Khoa> dskq = new List<Khoa>();
            lvSV.Items.Clear();
            if (e.Node.Level == 0)
            {
                string tenKhoa = tvKhoa.SelectedNode.Text;
                dskq = qLKhoa.DSTim(tenKhoa.Trim(), SoSanhTheoKhoa);
                LoadSVToListView(dskq);
            }
            else if (e.Node.Level == 1)
            {
                string tenLop = tvKhoa.SelectedNode.Text;
                dskq = qLKhoa.DSTim(tenLop.Trim(), SoSanhTheoLop);
                LoadSVToListView(dskq);
            }
        }
    }
}
