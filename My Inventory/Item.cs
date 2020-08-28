using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace My_Inventory
{
    public class Item
    {
        public string number;
        public string name;
        public string model;
        public string serial;
        public string user;
        public string place;
        public string date;
        public string discription;
        public List<Move> history;

        public Item()
        {
            //Ищем доступный номер
            int max = 0;
            if (Data.data != null)
            {
                foreach (Item itm in Data.data.items)
                {
                    int c = 0;
                    try { c = Convert.ToInt32(itm.number); } catch { }
                    if (c > max) max = c;
                }
            }
            number = (++max).ToString();
            history = new List<Move>();
        }

        /// <summary>
        /// Подготовка элемента таблицы ListViewItem
        /// </summary>
        /// <returns></returns>
        public ListViewItem GetListItem()
        {
            User usr = Data.data.users.Find(o => o.name == user);
            string[] str = { number, name + " " + model, this.user, date, place, discription };
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
            User usr = Data.data.users.Find(o => o.name == user);
            string[] str = { number, name + " " + model, date, place, discription };
            ListViewItem listItem = new ListViewItem(str);
            listItem.Tag = this;
            return listItem;
        }

        /// <summary>
        /// Добавление перемещения
        /// </summary>
        /// <param name="move"></param>
        public void AddMove(Move move)
        {
            history.Add(move);
            history.Sort((o1, o2) => o1.date.CompareTo(o2.date));
            bool notVoid = history.Count > 0;
            int last = history.Count - 1;
            date = notVoid ? history[last].date.ToString("dd.MM.yyyy") : "";
            user = notVoid ? history[last].user : "";
            place = notVoid ? history[last].place : "";
        }
    }
}
