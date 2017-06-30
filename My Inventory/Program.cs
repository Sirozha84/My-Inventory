using System;
using System.Windows.Forms;

namespace My_Inventory
{
    static class Program
    {
        public static string Url = "";
        public static string Site = "";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
            Properties.Settings.Default.Save();
        }
    }
}
