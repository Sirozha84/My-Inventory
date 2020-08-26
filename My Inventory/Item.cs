using System;
using System.Windows.Forms;

namespace My_Inventory
{
    public class Item
    {
        public string Number;
        public string Name;
        public string Model;
        public string Serial;
        public string User;
        public string Place;
        public string Date;
        public string Discription;

        public Item() { }

        public Item(string Number, string Name, string Model, string Serial, string User,
            string Place, string Date, string Discription)
        {
            this.Number = Number;
            this.Name = Name;
            this.Model = Model;
            this.Serial = Serial;
            this.User = User;
            this.Place = Place;
            this.Date = Date;
            this.Discription = Discription;
        }

        /// <summary>
        /// Подготовка элемента таблицы ListViewItem
        /// </summary>
        /// <returns></returns>
        public ListViewItem GetListItem()
        {
            User user = Data.data.Users.Find(o => o.Name == User);
            //string dep = user == null ? "" : user.Departament;
            string[] str = { Number, Name + " " + Model, User, Date, Place, Discription };
            ListViewItem listItem = new ListViewItem(str);
            listItem.Tag = this;
            return listItem;
        }

        /// <summary>
        /// Подготовка эдемента таблицы ListViewItem для списка предметов сотрудника
        /// </summary>
        /// <returns></returns>
        public ListViewItem GetListItemForUser()
        {
            User user = Data.data.Users.Find(o => o.Name == User);
            string dep = user == null ? "" : user.Departament;
            string[] str = { Number, Name + " " + Model, Date, Place, Discription };
            ListViewItem listItem = new ListViewItem(str);
            listItem.Tag = this;
            return listItem;
        }

        public int CompareTo(object obj)
        {
            try
            {
                return Convert.ToInt16(Number) > Convert.ToInt16(((Item)obj).Number) ? 1 : -1;
            }
            catch { return 1; }
        }
    }
}
