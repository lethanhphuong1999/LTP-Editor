using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LTP_Code
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var facebook = new ProcessStartInfo("chrome.exe");
            facebook.Arguments = "https://www.facebook.com/phuong.lethanh.3158";
            Process.Start(facebook);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var github = new ProcessStartInfo("chrome.exe");
            github.Arguments = "https://github.com/intiu";
            Process.Start(github);
        }
    }
}
