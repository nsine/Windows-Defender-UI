using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.ServiceProcess;
using Windows_Defender.Properties;
using System.Threading;
using System.Globalization;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Windows_Defender
{
    public partial class Form1 : Form
    {

        int defender, firewall; // Состояние антивируса и файерволла
        bool isUndefined; // Если защита никогда не отключалась, то ключа реестра нет
        string defenderStr, firewallStr;
        string programFilesPath =
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        Icon[] icons = new Icon[4];
        bool isIconsEnabled = false;
        bool oneClickProtection = false;

        enum Systems
        {
            windows7,
            windows8,
            windows10
        };

        Systems currentSystem = 0;

        public Form1()
        {
            // Читаем из реестра номер сборки для определения версии ОС
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            int osVersion = int.Parse(rk.GetValue("CurrentBuild").ToString());

            switch (osVersion / 1000) {
                case 10:
                    currentSystem = Systems.windows10;
                    break;
                case 9:
                    currentSystem = Systems.windows8;
                    break;
                case 7:
                    currentSystem = Systems.windows7;
                    break;
                default:
                    currentSystem = Systems.windows8;
                    break;
            }

            // Читаем конфиг из файла
            string mainIcon = "win8";
            string language = "ru-RU";
            string isIcons = "icons";
            string oneClick = "noOneClickProtection";

            bool isException = false;

            try {
                System.IO.StreamReader fileIn =
                    new System.IO.StreamReader("DefenderUiSettings.ini");
                mainIcon = fileIn.ReadLine();
                language = fileIn.ReadLine();
                isIcons = fileIn.ReadLine();
                oneClick = fileIn.ReadLine();
                fileIn.Close();
                fileIn.Dispose();
            } catch {
                isException = true;
            }

            if (isIcons == "icons") {
                isIconsEnabled = true;
            } else {
                isIconsEnabled = false;
            }

            InitializeComponent();
            switch (mainIcon) {
                case "win7":
                    icons[0] = Icons.main7;
                    icons[1] = Icons.warning7;
                    icons[2] = Icons.danger7;
                    break;
                case "win8":
                    icons[0] = Icons.main8;
                    icons[1] = Icons.warning8;
                    icons[2] = Icons.danger8;
                    break;
                case "win10":
                    icons[0] = Icons.main10;
                    icons[1] = Icons.warning10;
                    icons[2] = Icons.danger10;
                    break;
                case "shield":
                    icons[0] = Icons.mainShield;
                    icons[1] = Icons.WarningShield;
                    icons[2] = Icons.dangerShield;
                    break;
                default:
                    icons[0] = Icons.main8;
                    icons[1] = Icons.warning8;
                    icons[2] = Icons.danger8;
                    isException = false;
                    break;
            }
            icons[3] = Icons.undefined;

            switch (language) {
                case "en-US":
                    Lang.Culture = new CultureInfo("en-US");
                    break;
                case "ru-RU":
                    Lang.Culture = new CultureInfo("ru-RU");
                    break;
                default:
                    Lang.Culture = new CultureInfo("en-US");
                    isException = true;
                    break;
            }

            if (isIconsEnabled) {
                toolStripMenuItem1.Image = Icons.Defender.ToBitmap();
                toolStripMenuItem2.Image = Icons.Firewall.ToBitmap();
                toolStripMenuItem3.Image = Icons.ProtectionControl.ToBitmap();
                toolStripMenuItem4.Image = Icons.Scan.ToBitmap();
                toolStripMenuItem5.Image = Icons.Update.ToBitmap();
                toolStripMenuItem6.Image = Icons.DefenderSettings.ToBitmap();
                toolStripMenuItem7.Image = Icons.Exit.ToBitmap();
                toolStripMenuItem8.Image = Icons.Settings.ToBitmap();
                toolStripMenuItem12.Image = Icons.QuickScan.ToBitmap();
                toolStripMenuItem13.Image = Icons.FullScan.ToBitmap();
                toolStripMenuItem14.Image = Icons.UpdateAndScan.ToBitmap();
                toolStripMenuItem15.Image = Icons.Log.ToBitmap();
            }

            if (oneClick == "oneClickProtection") {
                oneClickProtection = true;
            } else {
                oneClickProtection = false;
            }

            // Если из файла не удалось прочитать параметры,
            // записываем стандартные и перезапускаем программу
            if (isException) {
                System.IO.StreamWriter fileOut =
                    new System.IO.StreamWriter("DefenderUiSettings.ini");
                fileOut.WriteLine(mainIcon);
                fileOut.WriteLine(language);
                fileOut.WriteLine(isIcons);
                fileOut.WriteLine(oneClick);
                fileOut.Close();
                fileOut.Dispose();
                Application.Restart();
            }

            toolStripMenuItem1.Text = Lang.WINDOWS_DEFENDER;
            toolStripMenuItem2.Text = Lang.WINDOWS_FIREWALL;
            toolStripMenuItem3.Text = Lang.PROTECTION_CONTROL;
            toolStripMenuItem4.Text = Lang.SCAN;
            toolStripMenuItem5.Text = Lang.UPDATE;
            toolStripMenuItem6.Text = Lang.SETTINGS;
            toolStripMenuItem8.Text = Lang.PROGRAM_SETTINGS;
            toolStripMenuItem7.Text = Lang.EXIT;

            toolStripMenuItem12.Text = Lang.QUICK_SCAN;
            toolStripMenuItem13.Text = Lang.FULL_SCAN;
            toolStripMenuItem14.Text = Lang.UPDATE_AND_SCAN;
            toolStripMenuItem15.Text = Lang.SHOW_LOG;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(programFilesPath + "\\Windows Defender\\MSASCui.exe");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start("control", "firewall.cpl");
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Process.Start(programFilesPath + "\\Windows Defender\\MSASCui.exe", "/QuickScan");
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Process.Start(programFilesPath + "\\Windows Defender\\MSASCui.exe", "/FullScan");
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Process.Start(programFilesPath + "\\Windows Defender\\MSASCui.exe", "/UpdateAndQuickScan");
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\MpCmdRun.log");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo =
                new ProcessStartInfo(@"C:\Program Files\Windows Defender\MpCmdRun.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "/SignatureUpdate";
            Process.Start(startInfo);
            notifyIcon1.ShowBalloonTip(5000, Lang.WINDOWS_DEFENDER,
                Lang.UPDATE_IN_PROGRESS, ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isUndefined) {
                notifyIcon1.Text = Lang.PROTECTION_STATE + "\n" + Lang.DEF + defenderStr + Lang.FIRE + firewallStr;
            } else {
                notifyIcon1.Text = Lang.UNDEFINED;
            }
            if (defender == 1 && firewall == 0) {
                toolStripMenuItem9.Text = Lang.ENABLE_PROTECTION;

                if (isIconsEnabled) {
                    toolStripMenuItem9.Image = Icons.on.ToBitmap();
                }
            } else {
                toolStripMenuItem9.Text = Lang.DISABLE_PROTECTION;

                if (isIconsEnabled) {
                    toolStripMenuItem9.Image = Icons.off.ToBitmap();
                }
            }

            if (defender == 1) {
                toolStripMenuItem10.Text = Lang.ENABLE_DEFENDER;

                if (isIconsEnabled) {
                    toolStripMenuItem10.Image = Icons.on.ToBitmap();
                }
            } else {
                toolStripMenuItem10.Text = Lang.DISABLE_DEFENDER;

                if (isIconsEnabled) {
                    toolStripMenuItem10.Image = Icons.off.ToBitmap();
                }
            }

            if (firewall == 0) {
                toolStripMenuItem11.Text = Lang.ENABLE_FIREWALL;

                if (isIconsEnabled) {
                    toolStripMenuItem11.Image = Icons.on.ToBitmap();
                }
            } else {
                toolStripMenuItem11.Text = Lang.DISABLE_FIREWALL;

                if (isIconsEnabled) {
                    toolStripMenuItem11.Image = Icons.off.ToBitmap();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((timer1 == null) || (sender == null) || (e == null)) {
                timer1.Dispose();
                timer1 = new System.Windows.Forms.Timer();
                return;
            }

            RegistryKey DisableRealtimeMonitoring;
            try {
                DisableRealtimeMonitoring =
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection");
                defender = (int)DisableRealtimeMonitoring.GetValue("DisableRealtimeMonitoring");
                DisableRealtimeMonitoring.Close();
                isUndefined = false;
            } catch {
                isUndefined = true;
            }

            if (isUndefined) {
                notifyIcon1.Icon = icons[3];
                return;
            }

            if (defender == 1) {
                defenderStr = Lang.OFF + "\n";
            } else {
                defenderStr = Lang.ON + "\n";
            }

            ServiceController sc = new ServiceController("MpsSvc");

            if (sc.Status.Equals(ServiceControllerStatus.Stopped)) {
                firewall = 0;
                firewallStr = Lang.OFF;
            } else {
                firewall = 1;
                firewallStr = Lang.ON;
            }
            if (defender == 0 && firewall == 1) {
                notifyIcon1.Icon = icons[0];
            } else if (defender == 0 || firewall == 1) {
                notifyIcon1.Icon = icons[1];
            } else {
                notifyIcon1.Icon = icons[2];
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (currentSystem == Systems.windows7) {
                if (defender == 1) {
                    try {
                        RegistryKey DisableRealtimeMonitoring =
                            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection", true);
                        DisableRealtimeMonitoring.SetValue("DisableRealtimeMonitoring",
                            unchecked((int)0x000000000), RegistryValueKind.DWord);
                        DisableRealtimeMonitoring.Close();
                    } catch {
                        toolStripMenuItem6_Click(sender, e);
                    }
                } else {
                    try {
                        RegistryKey DisableRealtimeMonitoring =
                            Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection", true);
                        DisableRealtimeMonitoring.SetValue("DisableRealtimeMonitoring", unchecked((int)0x000000001), RegistryValueKind.DWord);
                        DisableRealtimeMonitoring.Close();
                    } catch {
                        toolStripMenuItem6_Click(sender, e);
                    }
                }
            } else if (currentSystem == Systems.windows10 ||
                    currentSystem == Systems.windows8) {
                string newState;
                if (defender == 1) {
                    newState = "false";
                } else {
                    newState = "true";
                }

                try {
                    ProcessStartInfo cmdInfo = new ProcessStartInfo("cmd.exe", "/c " + "powershell.exe Set-MpPreference -DisableRealtimeMonitoring $" + newState);
                    cmdInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(cmdInfo);
                } catch {
                    toolStripMenuItem6_Click(sender, e);
                }
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            /*if (defender == 1 && firewall == 0)
            {
                RegistryKey DisableRealtimeMonitoring =
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection", true);
                DisableRealtimeMonitoring.SetValue("DisableRealtimeMonitoring", unchecked((int)0x000000000), RegistryValueKind.DWord);
                DisableRealtimeMonitoring.Close();
                ServiceController sc = new ServiceController("MpsSvc");
                sc.Start();
            } else if (defender == 0 && firewall == 0) {
                RegistryKey DisableRealtimeMonitoring =
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection", true);
                DisableRealtimeMonitoring.SetValue("DisableRealtimeMonitoring",
                    unchecked((int)0x000000001), RegistryValueKind.DWord);
                DisableRealtimeMonitoring.Close();
                ServiceController sc = new ServiceController("MpsSvc");  
            } else {

                RegistryKey DisableRealtimeMonitoring =
                    Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection", true);
                DisableRealtimeMonitoring.SetValue("DisableRealtimeMonitoring",
                    unchecked((int)0x000000001), RegistryValueKind.DWord);
                DisableRealtimeMonitoring.Close();
                ServiceController sc = new ServiceController("MpsSvc");
                sc.Stop();
            }*/
            toolStripMenuItem10_Click(sender, e);
            toolStripMenuItem11_Click(sender, e);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Process.Start(programFilesPath + "\\Windows Defender\\MSASCui.exe", "/Settings");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left  && !isUndefined) {
                Process.Start(programFilesPath + "\\Windows Defender\\MSASCui.exe");
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (firewall == 0) {
                ServiceController sc = new ServiceController("MpsSvc");
                try {
                    sc.Start();
                } catch {
                    MessageBox.Show("У Вас нет доступа к управлению Брандмауэром",
                        "Отказано в доступе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sc.Dispose();
            } else {
                ServiceController sc = new ServiceController("MpsSvc");
                try {
                    sc.Stop();
                } catch {
                    MessageBox.Show("У Вас нет доступа к управлению Брандмауэром",
                        "Отказано в доступе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sc.Dispose();
            }
        }

        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Activate();
            formSettings.Visible = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isUndefined && (e.Button == MouseButtons.Left)) {
                var result = MessageBox.Show(Lang.UNDEFINED_MB_TEXT,
                    Lang.UNDEFINED_MB_CAPTION, MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK) {
                    toolStripMenuItem6_Click(sender, e);
                }
            }

            if (!isUndefined && oneClickProtection &&
                (e.Button == MouseButtons.Middle)) {
                    toolStripMenuItem9_Click(sender, e);
            }
        }
    }
}
