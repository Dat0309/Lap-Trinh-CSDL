using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Specialized;

namespace Lab04_Demo_File_Explorer
{
    public partial class frmExplorer : Form
    {
        string curPath;
        public frmExplorer()
        {
            InitializeComponent();
        }

        private void frmExplorer_Load(object sender, EventArgs e)
        {
            TreeNode tnode = new TreeNode();
            tnode.Text = "Desktop";
            tnode.Tag = SpecialDirectories.Desktop;
            tnode.ImageKey = "Desktop";
            tnode.SelectedImageKey = "Desktop";

            treeViewFolder.Nodes.Add(tnode);
            string name = Application.StartupPath;
            name = name.Substring(0, name.LastIndexOf('\\'));
            name = name.Substring(0, name.LastIndexOf('\\'));
        }

        private string ImageKeyDriver(DriveInfo drive)
        {
            string type = "";

            switch (drive.DriveType)
            {
                case DriveType.Fixed:
                    type = "HDD";
                    break;
                case DriveType.CDRom:
                    type = "CD";
                    break;
                case DriveType.Removable:
                    type = "Removeable";
                    break;
                case DriveType.Network:
                    type = "Network";
                    break;
                default:
                    type = "HDD";
                    break;
            }
            return type;
        }

        private void LoadDrive(TreeNode tn)
        {
            TreeNode tnode = new TreeNode();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                tnode = new TreeNode();
                tnode.Text = drive.Name;
                tnode.Tag = drive.ToString();
                tnode.ImageKey = ImageKeyDriver(drive);
                tnode.SelectedImageKey = ImageKeyDriver(drive);
                tn.Nodes.Add(tnode);
            }
        }

        private void InsertFolder(TreeNode tnParent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());
                foreach (DirectoryInfo drive in dir.GetDirectories())
                {
                    TreeNode tnChild = new TreeNode();
                    tnChild.Text = drive.Name;
                    tnChild.ImageKey = "Folder";
                    tnChild.SelectedImageKey = "Folder";
                    tnChild.Tag = drive.FullName;
                    tnParent.Nodes.Add(tnChild);
                }
            }
            catch { }
        }

        private void InsertFileTreeView(TreeNode tnParent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());

                foreach (FileInfo file in dir.GetFiles())
                {
                    TreeNode tnChild = new TreeNode();
                    tnChild.Text = file.Name;
                    tnChild.ImageKey = "File";
                    tnChild.SelectedImageKey = "File";
                    tnParent.Nodes.Add(tnChild);
                }

            }
            catch { }
        }

        private void InsertFileListView(TreeNode tnParent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());

                listViewFile.Items.Clear();
                foreach (FileInfo file in dir.GetFiles())
                {
                    var item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.LastWriteTime.ToShortDateString());
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add((file.Length / 1024).ToString());

                    listViewFile.Items.Add(item);
                }

                toolStripStatusLabel1.Text = "Tong so Files: " + listViewFile.Items.Count;
            }
            catch { }
        }

        private void InsertChildParent(TreeNode tnParent)
        {
            //if (tnParent == null) return;
            if (tnParent != null)
            {
                if (tnParent.Level == 0)
                {
                    TreeNode tnMyDocuments = new TreeNode();
                    tnMyDocuments.Text = "My Documents";
                    tnMyDocuments.ImageKey = "My Documents";
                    tnMyDocuments.SelectedImageKey = "My Documents";
                    tnMyDocuments.Tag = SpecialDirectories.MyDocuments;

                    TreeNode tnMyComputer = new TreeNode();
                    tnMyDocuments.Text = "My Computer";
                    tnMyComputer.ImageKey = "My Computer";
                    tnMyComputer.SelectedImageKey = "My Computer";
                    tnMyComputer.Tag = "My Computer";

                    tnParent.Nodes.Insert(0, tnMyDocuments);
                    tnParent.Nodes.Insert(1, tnMyComputer);
                }
                else
                {
                    if (tnParent.Nodes.Count == 0)
                    {
                        if (tnParent.Text == "My Computer")
                        {
                            LoadDrive(tnParent);
                            return;
                        }
                        InsertFolder(tnParent);
                    }
                    InsertFileTreeView(tnParent);
                    InsertFileListView(tnParent);
                }
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tnParent = e.Node;
            curPath = tnParent.FullPath;
            //MessageBox.Show(curPath);
            InsertChildParent(tnParent);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curPath = curPath.Substring(20);
            string fullPath = curPath +"\\"+listViewFile.SelectedItems[0].Text;
            Process.Start(fullPath);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curPath = curPath.Substring(20);
            var list = new StringCollection();
            foreach (ListViewItem item in listViewFile.SelectedItems)
            {
                list.Add(curPath + "\\" + item.Text);
                Clipboard.SetFileDropList(list);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curPath = curPath.Substring(20);
            var list = new StringCollection();
            foreach (ListViewItem item in listViewFile.SelectedItems)
            {
                list.Add(curPath + "\\" + item.Text);
                Clipboard.SetFileDropList(list);
                File.Delete(curPath + "\\" + item.Text);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curPath = curPath.Substring(20);
            var list = new StringCollection();
            foreach (ListViewItem item in listViewFile.SelectedItems)
            {
                list.Add(curPath + "\\" + item.Text);
                File.Delete(curPath + "\\" + item.Text);
                frmExplorer_Load(sender, e);
            }
        }
    }
}
