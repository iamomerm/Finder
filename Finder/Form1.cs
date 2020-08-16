using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Security.Principal;

namespace Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Feed CB_Drives
            List<String> Drives = Drive.GetDrives();
            foreach (string Drive in Drives) { CB_Drives.Items.Add(Drive); }
            CB_Drives.SelectedIndex = 0;
        }

        bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        //Threads
        Thread ActionThread; /* 1 */

        private void Scan()
        {
            try
            {
                bool System_Files_Scan = this.CB_System_Files.Checked;

                this.Btn_Scan.Enabled = false;

                this.Btn_Scan.Text = "Scanning...";

                this.Btn_Scan.BackColor = System.Drawing.Color.LightGray;

                string Root = this.CB_Drives.Text;

                int Threshold = Int16.Parse(this.MTB_Threshold.Text);

                this.CLB_Files.Items.Clear();

                List<String> Files = new List<String>();

                Drive.GetFiles(Files, Root, Threshold, System_Files_Scan);

                foreach (string File in Files) { this.CLB_Files.Items.Add(File); }

                this.Btn_Scan.Enabled = true;

                this.Btn_Scan.Text = "Scan";

                this.Btn_Scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(186)))), ((int)(((byte)(200)))));
            }

            catch { /* Pass */ }
        }

        private void Remove()
        {
            foreach (string SelectedItem in this.CLB_Files.SelectedItems)
            {
                this.Btn_Scan.Enabled = false;

                string[] Splits = SelectedItem.Split('*');

                string Path = Splits[0].Substring(0, (Splits[0].Length - 1));

                string PowerShellCMD = "Write-Host 'Removing file: '" + Path + "; Remove-Item -Path '" + Path + "' -Force";
                System.Diagnostics.Process.Start("powershell.exe", PowerShellCMD);

                this.Btn_Scan.Enabled = true;
            }

            this.CLB_Files.Items.Clear();
        }

        private void ButtonScanClick(object sender, EventArgs e)
        {
            bool CheckAdmin = IsAdministrator();

            if (CheckAdmin == false)
            {

                MessageBox.Show
                    (
                    "This program must be executed as local admin!"
                    + Environment.NewLine +
                    "Right click - Run as administrator"
                    , "Finder"
                    );
            }

            else
            {
                ActionThread = new Thread(new ThreadStart(Scan));

                ActionThread.IsBackground = true;

                ActionThread.Start();
            }

        }

        private void ButtonExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelRemoveClick(object sender, EventArgs e)
        {
            ActionThread = new Thread(new ThreadStart(Remove));

            ActionThread.IsBackground = true;

            ActionThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Check Multiple Instances
            bool SingleInstance;

            Mutex Mutex = new Mutex(true, "Application", out SingleInstance);

            if (!SingleInstance)
            {
                MessageBox.Show("Instance of 'Finder' Is Already Running !", "Finder");

                //Exit Application
                System.Windows.Forms.Application.Exit();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e) {}
    }
}
