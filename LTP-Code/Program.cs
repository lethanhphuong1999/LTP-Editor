using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace LTP_Code
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
            /*Title form = new Title();
            form.Tabs.Add(
                new TitleBarTab(form)
                {
                    Content = new Form1
                    {
                        Text = "New Tab"
                    }
                }
            );

            form.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(form);
            Application.Run(applicationContext);*/
        }
    }
}
