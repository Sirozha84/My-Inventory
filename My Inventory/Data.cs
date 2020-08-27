using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace My_Inventory
{
    public class Data
    {
        public static Data data;
        
        public string ResponsiblePerson;
        public string Post;
        public List<Item> items = new List<Item>();
        public List<User> users = new List<User>();

        /// <summary>
        /// Загрузка базы данных
        /// </summary>
        public static void Load()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Data));
                using (var reader = new StreamReader("Data.xml"))
                    data = (Data)serializer.Deserialize(reader);
            }
            catch
            {
                data = new Data();
            }
        }

        /// <summary>
        /// Сохранение базы данных
        /// </summary>
        public static void Save()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(Data));
                using (var writer = new StreamWriter("Data.xml"))
                    serializer.Serialize(writer, data);
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении данных");
            }
        }

        /// <summary>
        /// Сортировка базы
        /// </summary>
        public static void Sort()
        {
            data.items.Sort((o1, o2) => o1.number.CompareTo(o2.number));
            data.users.Sort((o1, o2) => o1.name.CompareTo(o2.name));
        }
    }
}
