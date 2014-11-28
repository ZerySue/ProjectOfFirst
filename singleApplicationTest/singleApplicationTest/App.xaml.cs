using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace singleApplicationTest
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        [DllImport("user32", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindow(string cls, string win);
        [DllImport("user32")]
        static extern IntPtr SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32")]
        static extern bool IsIconic(IntPtr hWnd);
        [DllImport("user32")]
        static extern bool OpenIcon(IntPtr hWnd);

        protected override void OnStartup(StartupEventArgs e)
        {
            bool isNew;
            MessageBox.Show("1");
            var mutex = new Mutex(true, "My Singleton Instance", out isNew);
            if (!isNew)
            {
                ActivateOtherWindow();
                Shutdown();
                MessageBox.Show("2");
            }
        }
        private static void ActivateOtherWindow()
        {
            MessageBox.Show("3");
            var other = FindWindow(null, "MainWindow00");
            if (other != IntPtr.Zero)
            {
                SetForegroundWindow(other);
                if (IsIconic(other))
                    OpenIcon(other);
                MessageBox.Show("4");
            }
        }
    }
}
