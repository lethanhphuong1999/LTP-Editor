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
    public partial class Video1 : Form
    {
        public Video1()
        {
            InitializeComponent();
        }

        private void commandLink1_Click(object sender, EventArgs e)
        {
            var vc = new ProcessStartInfo("chrome.exe");
            vc.Arguments = "https://www.youtube.com/watch?v=52r9qUToOD8&list=PLLAZ4kZ9dFpNIBTYHNDrhfE9C-imUXCmk";
            Process.Start(vc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            var v1 = new ProcessStartInfo("chrome.exe");
            v1.Arguments = "https://www.mikedane.com/";
            Process.Start(v1);
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            var v2 = new ProcessStartInfo("chrome.exe");
            v2.Arguments = "https://www.facebook.com/giraffeacademy/";
            Process.Start(v2);
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            var v3 = new ProcessStartInfo("chrome.exe");
            v3.Arguments = "https://twitter.com/GiraffeAcademy";
            Process.Start(v3);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
