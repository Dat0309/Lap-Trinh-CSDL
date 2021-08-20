using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace BaiTapBuoi1
{
    public partial class LinkLb : Form
    {
        public LinkLb()
        {
            InitializeComponent();
        }

        private void LinkLb_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:ctk43@gmail.com";
            this.linkLabel1.Links.Add(0, strURL.Length, strURL);
            strURL = "https://www.facebook.com";
            this.linkLabel2.Links.Add(0, strURL.Length, strURL);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
            {
                Process.Start(strURL + "?subject=hello");
            }
        }

        private void linkLabel2_LinkClicked(object senders, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("https://www."))
                Process.Start(strURL);
        }
    }
}
