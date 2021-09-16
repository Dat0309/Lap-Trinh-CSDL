using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_MyEditor
{
    public partial class frmEditor : Form
    {
        public RichTextBox richTextBox;
        public frmEditor()
        {
            InitializeComponent();
            this.richTextBox = rtb;
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            this.rtb.Text = richTextBox.Text;
        }
    }
}
