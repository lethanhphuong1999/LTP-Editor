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
    public partial class Video2 : Form
    {
        public Video2()
        {
            InitializeComponent();
        }

        private void commandLink1_Click(object sender, EventArgs e)
        {
            var vhtml = new ProcessStartInfo("chrome.exe");
            vhtml.Arguments = "https://www.youtube.com/watch?v=UB1O30fR-EE&list=PLillGF-RfqbZTASqIqdvm1R5mLrQq79CU";
            Process.Start(vhtml);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            var v4 = new ProcessStartInfo("chrome.exe");
            v4.Arguments = "https://www.traversymedia.com";
            Process.Start(v4);
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            var v5 = new ProcessStartInfo("chrome.exe");
            v5.Arguments = "https://www.facebook.com/traversymedia";
            Process.Start(v5);
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            var v6 = new ProcessStartInfo("chrome.exe");
            v6.Arguments = "https://twitter.com/traversymedia";
            Process.Start(v6);
        }
    }
}
