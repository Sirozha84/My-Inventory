using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace My_Inventory
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Data.Load();
            Application.Run(new FormMain());
            Data.Save();
            Properties.Settings.Default.Save();
        }
    }
}
