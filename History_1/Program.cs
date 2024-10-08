using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace History_1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            //string mysqlStartPath = Path.Combine(directoryPath, @"..\..\MySQL_5_7\MySQL_start.exe");
            //string processName = "mysqld";
            //if (!IsProgressRunning(processName))
            //{
            //    if (File.Exists(mysqlStartPath))
            //        Process.Start(mysqlStartPath);
            //    else
            //        MessageBox.Show("MySQL_start.exe не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            Application.Run(new MainForm());
        }
        //static bool IsProgressRunning(string processName)
        //{
        //    Process[] processes = Process.GetProcessesByName(processName);
        //    return processes.Length > 0;
        //}
    }
}
