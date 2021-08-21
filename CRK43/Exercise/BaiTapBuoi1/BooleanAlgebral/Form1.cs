using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooleanAlgebral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbA_CheckedChanged(object sender, EventArgs e)
        {
            if (cbA.Checked == true)
                cbA.Text = "True";
            else
                cbA.Text = "False";
        }

        private void cbResult_CheckedChanged(object sender, EventArgs e)
        {
            if (cbResult.Checked == true)
                cbResult.Text = "True";
            else
                cbResult.Text = "False";
            
        }

        private void cbB_CheckedChanged(object sender, EventArgs e)
        {
            if (cbB.Checked == true)
                cbB.Text = "True";
            else
                cbB.Text = "False";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string[] strBooleanVales = { "True", "False" };
            string[] strOperation = { "A ^ B", "A v B" };
            Random rand = new Random();

            cbA.Text = strBooleanVales[rand.Next(2)];
            cbB.Text = strBooleanVales[rand.Next(2)];

            if (cbA.Text == "True")
                cbA.Checked = true;
            else
                cbA.Checked = false;

            if (cbB.Text == "True")
                cbB.Checked = true;
            else
                cbB.Checked = false;

            lbResult.Text = strOperation[rand.Next(2)];
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (lbResult.Text == "A ^ B")
            {
                if (cbA.Checked == true)
                {
                    if (cbB.Checked == true)
                    {
                        if (cbResult.Checked == true)
                            MessageBox.Show("Trả lời đúng rồi! Đạt giỏi quá!");
                        else if (cbResult.Checked == false)
                            MessageBox.Show("Trả lời sai");
                    }
                    else if (cbB.Checked == false)
                    {
                        if (cbResult.Checked == false)
                            MessageBox.Show("Trả lời đúng rồi! Đạt giỏi quá!");
                        else if (cbResult.Checked == true)
                            MessageBox.Show("Trả lời sai");
                    }
                }
                else if (cbA.Checked == false)
                {
                    if (cbB.Checked == true)
                    {
                        if (cbResult.Checked == false)
                            MessageBox.Show("Trả lời đúng rồi! Đạt giỏi quá!");
                        else if (cbResult.Checked == true)
                            MessageBox.Show("Trả lời sai");
                    }
                    else if (cbB.Checked == false)
                    {
                        if (cbResult.Checked == false)
                            MessageBox.Show("Trả lời đúng rồi! Đạt giỏi quá!");
                        else if (cbResult.Checked == true)
                            MessageBox.Show("Trả lời sai");
                    }
                }
            }
            else if(lbResult.Text == "A v B")
            {
                if (cbA.Checked == true)
                {
                    if (cbB.Checked == true)
                    {
                        if (cbResult.Checked == true)
                            MessageBox.Show("Trả lời đúng rồi! Đạt giỏi quá!");
                        else if (cbResult.Checked == false)
                            MessageBox.Show("Trả lời sai");
                    }
                    else if (cbB.Checked == false)
                    {
                        if (cbResult.Checked == true)
                            MessageBox.Show("Trả lời đúng rồi! Đạt giỏi quá!");
                        else if (cbResult.Checked == false)
                            MessageBox.Show("Trả lời sai");
                    }
                }
                else if (cbA.Checked == false)
                {
                    if (cbB.Checked == true)
                    {
                        if (cbResult.Checked == true)
                            MessageBox.Show("Trả lời đúng rồi! Đạt giỏi quá!");
                        else if (cbResult.Checked == false)
                            MessageBox.Show("Trả lời sai");
                    }
                    else if (cbB.Checked == false)
                    {
                        if (cbResult.Checked == false)
                            MessageBox.Show("Trả lời đúng rồi! Đạt giỏi quá!");
                        else if (cbResult.Checked == true)
                            MessageBox.Show("Trả lời sai");
                    }
                }
            }
        }

        private void benClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
