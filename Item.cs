using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Inventory
{
    class Item
    {
        public string Number;
        public string Name;
        public string User;
        public string Date;
        public string Discription;

        public Item(string Number, string Name, string User, string Date, string Discription)
        {
            this.Number = Number;
            this.Name = Name;
            this.User = User;
            this.Date = Date;
            this.Discription = Discription;
        }

        /// <summary>
        /// Подготовка элемента таблицы ListViewItem
        /// </summary>
        /// <returns></returns>
        public ListViewItem GetListItem()
        {
            User user = Data.Users.Find(o => o.Name == User);
            string dep = user == null ? "" : user.Departament;
            string[] str = { Number, Name, User, dep, Date, Discription };
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
            User user = Data.Users.Find(o => o.Name == User);
            string dep = user == null ? "" : user.Departament;
            string[] str = { Number, Name, Date, Discription };
            ListViewItem listItem = new ListViewItem(str);
            listItem.Tag = this;
            return listItem;
        }
    }
}
