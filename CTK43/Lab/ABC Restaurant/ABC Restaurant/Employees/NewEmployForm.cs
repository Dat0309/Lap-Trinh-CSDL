using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Restaurant.Employees
{
    public partial class NewEmployForm : Form
    {
        public NewEmployForm()
        {
            InitializeComponent();
        }

        private void NewEmployForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                try
                {
                    string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
                    SqlConnection conn = new SqlConnection(connString);

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE InsertEmployee @lastName,@firstName,@title,@birthDay,@address,@city,@region,@postalCode,@country,@phone,@photo,@note";

                    cmd.Parameters.Add("@lastName", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@firstName", SqlDbType.NVarChar, 100);
                    cmd.Parameters.Add("@title", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@birthDay", SqlDbType.SmallDateTime);
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@city", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@region", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@postalCode", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@country", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@photo", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@note", SqlDbType.NVarChar, 250);

                    cmd.Parameters["@lastName"].Value = txtLastName.Text;
                    cmd.Parameters["@firstName"].Value = txtFirstName.Text;
                    cmd.Parameters["@title"].Value = txtTitle.Text;
                    cmd.Parameters["@birthDay"].Value = dttpDate.Value.ToShortDateString();
                    cmd.Parameters["@address"].Value = txtAddress.Text;
                    cmd.Parameters["@city"].Value = txtCity.Text;
                    cmd.Parameters["@region"].Value = txtRegion.Text;
                    cmd.Parameters["@postalCode"].Value = txtPostalCode.Text;
                    cmd.Parameters["@country"].Value = txtContry.Text;
                    cmd.Parameters["@phone"].Value = mtbPhone.Text;
                    cmd.Parameters["@photo"].Value = txtPhoto.Text;
                    cmd.Parameters["@note"].Value = rtbNote.Text;


                    conn.Open();

                    int numRow = cmd.ExecuteNonQuery();

                    if (numRow > 0)
                    {
                        MessageBox.Show("Successfully adding new Customer", "Message");
                        DialogResult = DialogResult.OK;
                        this.ResetText();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Adding customer failed");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL Error");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ trường cần thiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = $"D:";
            DialogResult dlg = openFileDialog1.ShowDialog();
            if(dlg == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                txtPhoto.Text = fileName;
                pbImg.Load(fileName);
            }
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text)) return false;
            else if (string.IsNullOrEmpty(txtLastName.Text)) return false;
            else if(string.IsNullOrEmpty(txtAddress.Text)) return false;
            else if(string.IsNullOrEmpty(txtCity.Text)) return false;
            else if(string.IsNullOrEmpty(txtContry.Text)) return false;
            else return true;
        }
    }
}
