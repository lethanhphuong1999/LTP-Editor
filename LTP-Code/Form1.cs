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
using FastColoredTextBoxNS;


using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.CodeDom;
using EasyTabs;
using System.Diagnostics;

namespace LTP_Code
{
    public partial class Form1 : Form
    {

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

    public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fastColoredTextBox1.Text = "";
            
            
        }

        private void OpenDlg()
        {
            OpenFileDialog of = new OpenFileDialog();
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
                of.Filter = "C# File|*.cs|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
                of.Filter = "HTML File|*.html|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JS)
                of.Filter = "JS File|*.js|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.SQL)
                of.Filter = "SQL File|*.sql|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
                of.Filter = "PHP File|*.php|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.VB)
                of.Filter = "VB File|*.vb|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
                of.Filter = "LUA File|*.lua|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JSON)
                of.Filter = "JSON File|*.json|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.XML)
                of.Filter = "XML File|*.xml|Any File|*.*";
            else of.Filter = "Any File|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                fastColoredTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = of.FileName;
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDlg();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
            catch
            {
                SaveDlg();
            }
        }
        private void SaveDlg()
        {
            SaveFileDialog of = new SaveFileDialog();
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
                of.Filter = "C# File|*.cs|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
                of.Filter = "HTML File|*.html|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JS)
                of.Filter = "JS File|*.js|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.SQL)
                of.Filter = "SQL File|*.sql|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
                of.Filter = "PHP File|*.php|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.VB)
                of.Filter = "VB File|*.vb|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
                of.Filter = "LUA File|*.lua|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JSON)
                of.Filter = "JSON File|*.json|Any File|*.*";
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.XML)
                of.Filter = "XML File|*.xml|Any File|*.*";
            else of.Filter = "Any File|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(of.FileName);
                sr.Write(fastColoredTextBox1.Text);
                sr.Close();
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDlg();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void patseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.BackColor = cd.Color;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.ForeColor = cd.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog cd = new FontDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Font = cd.Font;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void documentMap1_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowGoToDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {           
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;                          
        }

        
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents document = new Documents();
            //this.Hide();
            document.Show();
            this.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Print();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void w3schoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileweb = @"C:\Users\ltpnt\source\repos\LTP-Code\LTP-Code\W3Schools Offline\index.html";
            Process.Start(fileweb);
        }

        private void dotnetmicrosoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new ProcessStartInfo("chrome.exe");
            a.Arguments = "https://dotnet.microsoft.com/learn/csharp";
            Process.Start(a);
        }

        private void w3schoolsOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new ProcessStartInfo("chrome.exe");
            c.Arguments = "https://www.w3schools.com/";
            Process.Start(c);
        }

        private void codecademyOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var b = new ProcessStartInfo("chrome.exe");
            b.Arguments = "https://www.codecademy.com/learn/learn-c-sharp";
            Process.Start(b);
        }

        private void headFirstCSharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book1 b1 = new Book1();
            //this.Hide();
            b1.Show();
            this.Show();
        }

        private void lapTrinhCCoBanDenNangCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book2 b2 = new Book2();
            //this.Hide();
            b2.Show();
            this.Show();
        }

        private void cSharpProgrammingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book3 b3 = new Book3();
            //this.Hide();
            b3.Show();
            this.Show();
        }

        private void hTMLCSSDesignAndBuildWebsitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book4 b4 = new Book4();
            //this.Hide();
            b4.Show();
            this.Show();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load_1(object sender, EventArgs e)
        {

        }

        private void bUILDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cTutorialFullCourseForBeginnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Video1 d = new Video1();
            //this.Hide();
            d.Show();
            this.Show();
        }

        private void hTMLCSSTutorialForBeginnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Video2 f = new Video2();
            //this.Hide();
            f.Show();
            this.Show();
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var me = new ProcessStartInfo("chrome.exe");
            me.Arguments = "https://github.com/intiu";
            Process.Start(me);
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            OpenDlg();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
            catch
            {
                SaveDlg();
            }
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            SaveDlg();
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Print();
        }

        private void gunaPictureBox5_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void gunaPictureBox6_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void gunaPictureBox7_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void gunaPictureBox8_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void gunaPictureBox9_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void gunaPictureBox10_Click(object sender, EventArgs e)
        {
            FontDialog cd = new FontDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Font = cd.Font;
            }
        }

        private void gunaPictureBox11_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.ForeColor = cd.Color;
            }
        }

        private void gunaPictureBox12_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.BackColor = cd.Color;
            }
        }

        private void gunaPictureBox13_Click(object sender, EventArgs e)
        {
            Documents document = new Documents();
            //this.Hide();
            document.Show();
            this.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                Form2 h = new Form2(fastColoredTextBox1.Text);
                h.Show();
            }

            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Executable File|*.exe";
                string OutPath = "?.exe";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    OutPath = sf.FileName;
                }
                //compile code:
                //create c# code compiler
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                //create new parameters for compilation and add references(libs) to compiled app
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll" });
                //is compiled code will be executable?(.exe)
                parameters.GenerateExecutable = true;
                //output path
                parameters.OutputAssembly = OutPath;
                //code sources to compile
                string[] sources = { fastColoredTextBox1.Text };
                //results of compilation
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, sources);

                //if has errors
                if (results.Errors.Count > 0)
                {
                    string errsText = "";
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        errsText = "(" + CompErr.ErrorNumber +
                                    ")Line " + CompErr.Line +
                                    ",Column " + CompErr.Column +
                                    ":" + CompErr.ErrorText + "" +
                                    Environment.NewLine;
                    }
                    //show error message
                    MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //run compiled app
                    System.Diagnostics.Process.Start(OutPath);
                }

            }
            else
            {
                MessageBox.Show("Can't Run this file");
            }
        }

        private void buildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                Form2 h = new Form2(fastColoredTextBox1.Text);
                h.Show();
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Executable File|*.exe";
                string OutPath = "?.exe";

                OutPath = sf.FileName;

                //compile code:
                //create c# code compiler
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                //create new parameters for compilation and add references(libs) to compiled app
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll" });
                //is compiled code will be executable?(.exe)
                parameters.GenerateExecutable = true;
                //output path
                parameters.OutputAssembly = OutPath;
                //code sources to compile
                string[] sources = { fastColoredTextBox1.Text };
                //results of compilation
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, sources);

                //if has errors
                if (results.Errors.Count > 0)
                {
                    string errsText = "";
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        errsText = "(" + CompErr.ErrorNumber +
                                    ")Line " + CompErr.Line +
                                    ",Column " + CompErr.Column +
                                    ":" + CompErr.ErrorText + "" +
                                    Environment.NewLine;
                    }
                    //show error message
                    //MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Build complete and No Error");
                }
            }
            else
            {
                MessageBox.Show("Can't Build this file");
            }
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                Form2 h = new Form2(fastColoredTextBox1.Text);
                h.Show();
            }

            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Executable File|*.exe";
                string OutPath = "?.exe";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    OutPath = sf.FileName;
                }
                //compile code:
                //create c# code compiler
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                //create new parameters for compilation and add references(libs) to compiled app
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll" });
                //is compiled code will be executable?(.exe)
                parameters.GenerateExecutable = true;
                //output path
                parameters.OutputAssembly = OutPath;
                //code sources to compile
                string[] sources = { fastColoredTextBox1.Text };
                //results of compilation
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, sources);

                //if has errors
                if (results.Errors.Count > 0)
                {
                    string errsText = "";
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        errsText = "(" + CompErr.ErrorNumber +
                                    ")Line " + CompErr.Line +
                                    ",Column " + CompErr.Column +
                                    ":" + CompErr.ErrorText + "" +
                                    Environment.NewLine;
                    }
                    //show error message
                    MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //run compiled app
                    System.Diagnostics.Process.Start(OutPath);
                }

            }
            else
            {
                MessageBox.Show("Can't Run this file");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            //this.Hide();
            about.Show();
            this.Show();
        }
    }
}
