using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UACSkipper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            Process vbs = new Process();
            string processFileName = string.Empty;
            processFileName = @"C:\Windows\System32\wscript.exe";
            vbs.StartInfo.FileName = processFileName;
            vbs.StartInfo.Arguments = "delskipuac.vbs";
            vbs.StartInfo.CreateNoWindow = false;
            vbs.StartInfo.Verb = "runas";
            vbs.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            vbs.StartInfo.UseShellExecute = false;
            vbs.StartInfo.RedirectStandardOutput = true;
            vbs.StartInfo.LoadUserProfile = true;
            vbs.StartInfo.RedirectStandardOutput = true;
            vbs.StartInfo.RedirectStandardError = true;
            vbs.StartInfo.ErrorDialog = true;
            vbs.Start();
            vbs.WaitForExit();
            int exitcode = vbs.ExitCode;
            vbs.Close();
            Console.WriteLine("Exit code: " + exitcode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            Process vbs = new Process();
            string processFileName = string.Empty;
            processFileName = @"C:\Windows\System32\wscript.exe";
            vbs.StartInfo.FileName = processFileName;
            vbs.StartInfo.Arguments = "skipuac.vbs";
            vbs.StartInfo.CreateNoWindow = false;
            vbs.StartInfo.Verb = "runas";
            vbs.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            vbs.StartInfo.UseShellExecute = false;
            vbs.StartInfo.RedirectStandardOutput = true;
            vbs.StartInfo.LoadUserProfile = true;
            vbs.StartInfo.RedirectStandardOutput = true;
            vbs.StartInfo.RedirectStandardError = true;
            vbs.StartInfo.ErrorDialog = true;
            vbs.Start();
            vbs.WaitForExit();
            int exitcode = vbs.ExitCode;
            vbs.Close();
            Console.WriteLine("Exit code: " + exitcode);
        }
    }
}
