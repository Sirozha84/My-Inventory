using System;
using System.Windows.Forms;

namespace My_Inventory
{
    static class Program
    {
        public static string Site = "http://www.sg-software.ru";
        public static string ProgramPage = "http://www.sg-software.ru/windows/programs/my_inventory";
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
