using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chuong4_Part1_BaiTap1
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
            Application.Run(new TinhTong_BT1());
        }
    }
}
