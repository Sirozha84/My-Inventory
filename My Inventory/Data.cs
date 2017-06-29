using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace My_Inventory
{
    class Data
    {
        public static string ResponsiblePerson;
        public static string Post;

        public static List<Item> Items = new List<Item>();
        public static List<User> Users = new List<User>();
        public static List<LogRecord> Log = new List<LogRecord>();
        const string fileName = "DB.txt";

        /// <summary>
        /// Загрузка базы данных
        /// </summary>
        public static void Load()
        {
            if (!File.Exists(fileName)) return;
            try
            {
                using (StreamReader file = File.OpenText(fileName))
                {
                    //Загрузка параметров предприятия
                    file.ReadLine();
                    ResponsiblePerson = file.ReadLine();
                    Post = file.ReadLine();
                    //Загрузка предметов
                    file.ReadLine();
                    int c = Convert.ToInt32(file.ReadLine());
                    for (int i = 0; i < c; i++)
                        Items.Add(new Item(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(),
                            file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine()));
                    //Загрузка пользователей
                    file.ReadLine();
                    c = Convert.ToInt32(file.ReadLine());
                    for (int i = 0; i < c; i++)
                        Users.Add(new User(file.ReadLine(), file.ReadLine(),
                            file.ReadLine(), file.ReadLine()));
                    //Загрузка журнала
                    file.ReadLine();
                    c = Convert.ToInt32(file.ReadLine());
                    for (int i = 0; i < c; i++)
                        Log.Add(new LogRecord(file.ReadLine(), file.ReadLine(),
                            file.ReadLine(), file.ReadLine()));
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при загрузке базы данных.", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение базы данных
        /// </summary>
        public static void Save()
        {
            try
            {
                using (StreamWriter file = File.CreateText(fileName))
                {
                    file.WriteLine("-----------------------------------Options-----------------------------------");
                    file.WriteLine(ResponsiblePerson);
                    file.WriteLine(Post);
                    file.WriteLine("------------------------------------Items------------------------------------");
                    file.WriteLine(Items.Count);
                    foreach (Item item in Items)
                    {
                        file.WriteLine(item.Number);
                        file.WriteLine(item.Name);
                        file.WriteLine(item.Model);
                        file.WriteLine(item.Serial);
                        file.WriteLine(item.User);
                        file.WriteLine(item.Place);
                        file.WriteLine(item.Date);
                        file.WriteLine(item.Discription);
                    }
                    file.WriteLine("------------------------------------Users------------------------------------");
                    file.WriteLine(Users.Count);
                    foreach (User user in Users)
                    {
                        file.WriteLine(user.Name);
                        file.WriteLine(user.Post);
                        file.WriteLine(user.Organisation);
                        file.WriteLine(user.Departament);
                    }
                    file.WriteLine("------------------------------------Log------------------------------------");
                    file.WriteLine(Log.Count);
                    foreach (LogRecord rec in Log)
                    {
                        file.WriteLine(rec.Date);
                        file.WriteLine(rec.Num);
                        file.WriteLine(rec.ItemName);
                        file.WriteLine(rec.MoveRec);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при сохранении базы данных.", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сортировка базы
        /// </summary>
        public static void Sort()
        {
            Items.Sort();
            Users.Sort();
        }
    }
}
