using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab04_MyEditor
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void setEnabled(int c)
        {
            if (c > 0)
            {
                fileToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                formatToolStripMenuItem.Enabled = true;
                windowToolStripMenuItem.Enabled = true;
            }
            else
            {
                fileToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                formatToolStripMenuItem.Enabled = false;
                windowToolStripMenuItem.Enabled = false;
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmEditor frm = new frmEditor();
            frm.MdiParent = this;
            count++;
            frm.Text = "Blank Editor " + count;
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(formClosed);
            toolStripStatusLabel1.Text = "Số cửa sổ đang mở: " + count;
            setEnabled(count);
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            count--;
            toolStripStatusLabel1.Text = "Số cửa sổ đang mở: " + count;
            setEnabled(count);
        }

        public bool FormIsOpen(FormCollection application, Type formtype)
        {
            return Application.OpenForms.Cast<Form>().Any(x => x.GetType() == formtype);
        }

        private void tsbbOpen_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDialog1.ShowDialog();
            
            if(dlg == DialogResult.OK)
            {
                frmEditor frm = new frmEditor();
                try
                {
                    using(StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        frm.richTextBox.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                    frm.MdiParent = this;
                    frm.Show();
                    count++;
                    frm.FormClosed += new FormClosedEventHandler(formClosed);
                    toolStripStatusLabel1.Text = "Số cửa sổ đang mở: " + count;
                    setEnabled(count);
                }
                catch 
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.saveFileDialog1.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                frmEditor frm = this.ActiveMdiChild as frmEditor;
                try
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(frm.richTextBox.Text);
                    sw.Close();
                }
                catch {
                    MessageBox.Show("Loi luu file");
                }
            }
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            frmEditor frm = this.ActiveMdiChild as frmEditor;
            frm.richTextBox.Copy();
        }

        private void tsbCut_Click(object sender, EventArgs e)
        {
            frmEditor frm = this.ActiveMdiChild as frmEditor;
            frm.richTextBox.Cut();
        }

        private void tsbPaste_Click(object sender, EventArgs e)
        {
            frmEditor frm = this.ActiveMdiChild as frmEditor;
            frm.richTextBox.Paste();
        }

        private void tsbLeft_Click(object sender, EventArgs e)
        {
        }

        private void tsbCenter_Click(object sender, EventArgs e)
        {

        }

        private void tsbRight_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                tsccbFont.Items.Add(font.Name.ToString());
            }
            
        }

        private void tsccbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmEditor frm = this.ActiveMdiChild as frmEditor;
            try
            {
                frm.richTextBox.Font = new Font(tsccbFont.Text, frm.richTextBox.Font.Size);
            }
            catch 
            {
            }
        }


        private void tsColor_Click(object sender, EventArgs e)
        {
            frmEditor frm = this.ActiveMdiChild as frmEditor;
            DialogResult dlg = this.colorDialog1.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                frm.richTextBox.ForeColor = colorDialog1.Color;
            }
        }

        private void tsccbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmEditor frm = this.ActiveMdiChild as frmEditor;
            try
            {
                frm.richTextBox.Font = new Font(frm.richTextBox.Font.FontFamily, float.Parse(tsccbSize.SelectedItem.ToString()));
            }
            catch
            {
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbNew.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbbOpen.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbSave.PerformClick();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor frm = this.ActiveMdiChild as frmEditor;
            frm.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbCut.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbCopy.PerformClick();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbPaste.PerformClick();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.fontDialog1.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                frmEditor frm = this.ActiveMdiChild as frmEditor;
                try
                {
                    frm.richTextBox.Font = fontDialog1.Font;
                }
                catch
                {
                }
            }    
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsColor.PerformClick();
        }
    }
}
