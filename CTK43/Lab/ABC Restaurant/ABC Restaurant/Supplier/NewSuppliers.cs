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

namespace ABC_Restaurant.Supplier
{
    public partial class NewSuppliers : Form
    {
        public NewSuppliers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                try
                {
                    string connString = "server=WINDOWS-11\\SQLEXPRESS; database = NorthwindCompany; Integrated Security = true; ";
                    SqlConnection conn = new SqlConnection(connString);

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "EXECUTE InsertSupplier @companyName,@contactName,@address,@city,@region,@postalCode,@country,@phone,@fax,@homePage";

                    cmd.Parameters.Add("@companyName", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@contactName", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@city", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@region", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@postalCode", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@country", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@fax", SqlDbType.NVarChar, 250);
                    cmd.Parameters.Add("@homePage", SqlDbType.NVarChar, 250);

                    cmd.Parameters["@companyName"].Value = txtCompanyName.Text;
                    cmd.Parameters["@contactName"].Value = txtContactName.Text;
                    cmd.Parameters["@address"].Value = txtAddress.Text;
                    cmd.Parameters["@city"].Value = txtCity.Text;
                    cmd.Parameters["@region"].Value = txtRegion.Text;
                    cmd.Parameters["@postalCode"].Value = txtPostalCode.Text;
                    cmd.Parameters["@country"].Value = txtContry.Text;
                    cmd.Parameters["@phone"].Value = mtbPhone.Text;
                    cmd.Parameters["@fax"].Value = mtbFax.Text;
                    cmd.Parameters["@homePage"].Value = txtHomePage.Text;

                    conn.Open();

                    int numRow = cmd.ExecuteNonQuery();

                    if (numRow > 0)
                    {
                        MessageBox.Show("Successfully adding new Supplier", "Message");
                        this.ResetText();
                        DialogResult = DialogResult.OK;
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
                MessageBox.Show("Chưa nhập đủ trường", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text)) return false;
            else if (string.IsNullOrEmpty(txtContactName.Text)) return false;
            else if (string.IsNullOrEmpty(txtContactTitle.Text)) return false;
            else if (string.IsNullOrEmpty(txtAddress.Text)) return false;
            else if (string.IsNullOrEmpty(txtCity.Text)) return false;
            else if (string.IsNullOrEmpty(txtContry.Text)) return false;
            else return true;
        }
    }
}
