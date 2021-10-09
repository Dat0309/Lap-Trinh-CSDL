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
using System.IO;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace OnTapKiemTra1
{
    public partial class Form1 : Form
    {
        private QLSV qlsv;
        private const string _placeHolderText = "Nhập thông tin cần tìm !!!!";
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
            ListViewItem item = new ListViewItem(sv.StudentId);
            item.SubItems.Add(sv.FirstName);
            item.SubItems.Add(sv.LastName);
            item.SubItems.Add(sv.Gender == true?"Nam":"Nu");
            item.SubItems.Add(sv.DateOfBirth.ToShortDateString());
            item.SubItems.Add(sv.PhoneNumber);
            item.SubItems.Add(sv.ClassName);
            item.SubItems.Add(sv.FacultyName);
            item.SubItems.Add(sv.Address);

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
                StudentId = item.SubItems[0].Text,
                FirstName = item.SubItems[1].Text,
                LastName = item.SubItems[2].Text,
                Gender = item.SubItems[3].Text == "Nam" ? true : false,
                DateOfBirth = DateTime.Parse(item.SubItems[4].Text),
                PhoneNumber = item.SubItems[5].Text,
                ClassName = item.SubItems[6].Text,
                FacultyName = item.SubItems[7].Text,
                Address = item.SubItems[8].Text
            };
        }

        private string GetKhoa(SinhVien sv)
        {
            return sv.FacultyName;
        }
        private string GetLop(SinhVien sv)
        {
            return sv.ClassName;
        }

        private int SoSanhTheoKhoa(object obj1, object obj2)
        {
            return (obj2 as SinhVien).FacultyName.CompareTo(obj1.ToString());
        }
        private int SoSanhTheoLop(object obj1, object obj2)
        {
            return (obj2 as SinhVien).ClassName.CompareTo(obj1.ToString());
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.StudentId.CompareTo(obj1);
        }
        private int SoSanhTheoTen(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.LastName.CompareTo(obj1);
        }

        private void SetUpSearchInputText()
        {
            txtSearch.Text = _placeHolderText;
            txtSearch.GotFocus += RemovePlaceHolerText;
            txtSearch.LostFocus += ShowPlaceHolderText;
        }

        private void ShowPlaceHolderText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                txtSearch.Text = _placeHolderText;
        }

        private void RemovePlaceHolerText(object sender, EventArgs e)
        {
            if (txtSearch.Text == _placeHolderText)
                txtSearch.Text = "";
        }

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

        private void WriteToJson(List<SinhVien> sv, string fn)
        {
            using(StreamWriter file = File.CreateText(fn))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, sv);
            }
        }

        private List<SinhVien> ReadJson(string fn)
        {
            if (!File.Exists(fn))
            {
                FileStream fs = File.Create(fn);
                fs.Close();
            }
            using(StreamReader sr = new StreamReader(fn))
            {
                string json = sr.ReadToEnd();
                if (string.IsNullOrEmpty(json))
                    return new List<SinhVien>();
                List<SinhVien> items = JsonConvert.DeserializeObject<List<SinhVien>>(json);
                return items;
            }
        }

        private void WriteToExcel(ListView lv,List<SinhVien> listSV, string path)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage p = new ExcelPackage())
            {
                p.Workbook.Worksheets.Add("sheet 1");
                ExcelWorksheet ws = p.Workbook.Worksheets[0];
                ws.Name = "sheet 1";
                ws.Cells.Style.Font.Size = 11;
                ws.Cells.Style.Font.Name = "Calibri";

                List<string> arrCollumHeader = new List<string>();
                foreach (ColumnHeader item in lv.Columns)
                {
                    arrCollumHeader.Add(item.Text);
                }
                var countColHeader = arrCollumHeader.Count();

                int colIndex = 1;
                int rowIndex = 1;
                //Tao cac Header
                foreach (var item in arrCollumHeader)
                {
                    var cell = ws.Cells[rowIndex, colIndex];
                    var style = cell.Style.Font;
                    style.Bold = true;

                    cell.Value = item;
                    colIndex++;
                }

                //Lay danh sach sinh vien
                foreach (var item in listSV)
                {
                    colIndex = 1;
                    rowIndex++;
                    ws.Cells[rowIndex, colIndex++].Value = item.StudentId;
                    ws.Cells[rowIndex, colIndex++].Value = item.FirstName;
                    ws.Cells[rowIndex, colIndex++].Value = item.LastName;
                    ws.Cells[rowIndex, colIndex++].Value = item.Gender;
                    ws.Cells[rowIndex, colIndex++].Value = item.DateOfBirth.ToShortDateString();
                    ws.Cells[rowIndex, colIndex++].Value = item.PhoneNumber;
                    ws.Cells[rowIndex, colIndex++].Value = item.ClassName;
                    ws.Cells[rowIndex, colIndex++].Value = item.FacultyName;
                    ws.Cells[rowIndex, colIndex++].Value = item.Address;
                }
                //save file
                Byte[] bin = p.GetAsByteArray();
                File.WriteAllBytes(path, bin);
            }
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSVToListView(qlsv.dssv);
            ShowFeedOnTreeView(newRepo.GetKhoa());
            SetUpSearchInputText();
        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<SinhVien> dskq = new List<SinhVien>();
            lvSV.Items.Clear();
            if(e.Node.Level == 0)
            {
                string tenKhoa = tvKhoa.SelectedNode.Text;
                dskq = qlsv.DSTim(tenKhoa.Trim(), SoSanhTheoKhoa);
                LoadSVToListView(dskq);
            }
            else if(e.Node.Level == 1)
            {
                string tenLop = tvKhoa.SelectedNode.Text;
                dskq = qlsv.DSTim(tenLop.Trim(), SoSanhTheoLop);
                LoadSVToListView(dskq);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<SinhVien> dskq = new List<SinhVien>();
            lvSV.Items.Clear();

            if (rbMSSV.Checked)
            {
                foreach (var sv in qlsv.dssv)
                    if (sv.StudentId.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()))
                        dskq.Add(sv);
                LoadSVToListView(dskq);
            }
            if (rbHoTen.Checked)
            {
                foreach (var sv in qlsv.dssv)
                    if (sv.LastName.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()))
                        dskq.Add(sv);
                LoadSVToListView(dskq);
            }
            if (rbSDT.Checked)
            {
                foreach (var sv in qlsv.dssv)
                    if (sv.PhoneNumber.ToLower().StartsWith(txtSearch.Text.Trim().ToLower()))
                        dskq.Add(sv);
                LoadSVToListView(dskq);
            }
            if (txtSearch.Text == _placeHolderText)
                LoadSVToListView(qlsv.dssv);
        }

        private void tsmiThem_Click(object sender, EventArgs e)
        {
            List<SinhVien> dskq = new List<SinhVien>();
            frmStudentInfo frm = new frmStudentInfo(qlsv, newRepo);
            int count = lvSV.SelectedItems.Count;
            if(count >0)
            {
                ListViewItem item = lvSV.SelectedItems[0];
                frm.tenKhoa = GetKhoa(GetSVLV(item));
                frm.tenLop = GetLop(GetSVLV(item));
            }
            else
            {
                ListViewItem item = lvSV.Items[0];
                frm.tenKhoa = GetKhoa(GetSVLV(item));
                frm.tenLop = GetLop(GetSVLV(item));
            }

            if(frm.ShowDialog() == DialogResult.OK)
            {
                dskq = qlsv.DSTim(frm.tenLop.Trim(), SoSanhTheoLop);
                LoadSVToListView(dskq);
            }
        }

        private void tsmiXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem item;
            count = lvSV.Items.Count-1;
            DialogResult dlg = MessageBox.Show("Bạn có chắc muốn xóa sinh viên khỏi danh sách?!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dlg == DialogResult.Yes)
            {
                for (i = count; i >= 0; i--)
                {
                    item = lvSV.Items[i];
                    if (item.Selected)
                        qlsv.Xoa(item.SubItems[0].Text, SoSanhTheoMa);
                }
                LoadSVToListView(qlsv.dssv);
                MessageBox.Show("Đã xóa sinh viên");
            }
        }

        private void lvSV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            List<SinhVien> dskq = new List<SinhVien>();
            frmStudentInfo frm = new frmStudentInfo(qlsv, newRepo);
            int count = lvSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem item = lvSV.SelectedItems[0];
                frm.sv = GetSVLV(item);
                if (frm.ShowDialog() == DialogResult.Yes)
                {
                    sinhVien = qlsv.Tim(frm.sv.StudentId.Trim(), SoSanhTheoMa);
                    dskq.Add(sinhVien);
                    LoadSVToListView(dskq);
                }  
            }
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<SinhVien> dskq = new List<SinhVien>();
            TreeNode selectedNode = tvKhoa.SelectedNode;
            if (tvKhoa.SelectedNode != null)
            {
                if (tvKhoa.SelectedNode.Level == 0)
                {
                    saveFileDlg.FileName = selectedNode.Text;
                    saveFileDlg.InitialDirectory = @"D:\";
                    saveFileDlg.DefaultExt = "json";
                    saveFileDlg.Filter = "Json files(json) (*.json)|*.json";
                    DialogResult dlg = saveFileDlg.ShowDialog();

                    if (dlg == DialogResult.OK)
                    {
                        string path = string.Format(@"{0}", saveFileDlg.FileName);
                        dskq = qlsv.DSTim(selectedNode.Text.Trim(), SoSanhTheoKhoa);
                        WriteToJson(dskq, path);
                        MessageBox.Show("Xuất file thành công");
                    }
                }
                else if(tvKhoa.SelectedNode.Level > 0)
                {
                    saveFileDlg.FileName = selectedNode.Text;
                    saveFileDlg.InitialDirectory = @"D:\";
                    saveFileDlg.DefaultExt = "json";
                    saveFileDlg.Filter = "Json files(json) (*.json)|*.json";
                    DialogResult dlg = saveFileDlg.ShowDialog();

                    if (dlg == DialogResult.OK)
                    {
                        string path = string.Format(@"{0}", saveFileDlg.FileName);
                        dskq = qlsv.DSTim(selectedNode.Text.Trim(), SoSanhTheoLop);
                        WriteToJson(dskq, path);
                        MessageBox.Show("Xuất file thành công");
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn danh sách lớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tvKhoa.SelectedNode != null) { 
            List<SinhVien> dskq = new List<SinhVien>();
            TreeNode selectedNode = tvKhoa.SelectedNode;
                if (tvKhoa.SelectedNode.Level ==0)
                {
                    saveFileDlg.FileName = selectedNode.Text;
                    saveFileDlg.InitialDirectory = @"D:\";
                    saveFileDlg.DefaultExt = "xlsx";
                    saveFileDlg.Filter = "Excel 2007 files(xlsx) (*.xlsx)|*.xlsx";

                    DialogResult dlg = saveFileDlg.ShowDialog();
                    if (dlg == DialogResult.OK)
                    {
                        string path = string.Format(@"{0}", saveFileDlg.FileName);
                        dskq = qlsv.DSTim(selectedNode.Text.Trim(), SoSanhTheoKhoa);
                        WriteToExcel(lvSV, dskq, path);
                        MessageBox.Show("Xuất file thành công");
                    }
                }
                if(tvKhoa.SelectedNode.Level > 0)
                {
                    saveFileDlg.FileName = selectedNode.Text;
                    saveFileDlg.InitialDirectory = @"D:\";
                    saveFileDlg.DefaultExt = "xlsx";
                    saveFileDlg.Filter = "Excel 2007 files(xlsx) (*.xlsx)|*.xlsx";

                    DialogResult dlg = saveFileDlg.ShowDialog();
                    if (dlg == DialogResult.OK)
                    {
                        string path = string.Format(@"{0}", saveFileDlg.FileName);
                        dskq = qlsv.DSTim(selectedNode.Text.Trim(), SoSanhTheoLop);
                        WriteToExcel(lvSV, dskq, path);
                        MessageBox.Show("Xuất file thành công");
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn danh sách lớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ReadJsonDatatsmi_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tvKhoa.SelectedNode;
            if(tvKhoa.SelectedNode != null)
            {
                openFile.InitialDirectory = @"D:\";
                openFile.DefaultExt = "json";
                openFile.Filter = "Json files(json) (*.json)|*.json";
                DialogResult dlg = openFile.ShowDialog();

                if (dlg == DialogResult.OK)
                {
                    string path = string.Format(@"{0}", openFile.FileName);
                    foreach (var item in ReadJson(path))
                    {
                        qlsv.Them(item);
                    }
                    LoadSVToListView(qlsv.dssv);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp muốn thêm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
