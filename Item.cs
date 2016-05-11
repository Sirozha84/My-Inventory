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
            string[] str = { Number, Name, User, "---", Date, Discription };
            ListViewItem listItem = new ListViewItem(str);
            listItem.Tag = this;
            return listItem;
        }
    }
}
