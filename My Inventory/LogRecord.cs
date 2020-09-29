using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Inventory
{
    class LogRecord
    {
        public DateTime date;
        string num;
        string name;
        string user;
        string place;
        string comment;

        public LogRecord(Item item, Move move)
        {
            date = move.date;
            num = item.number;
            name = item.name + " " + item.model;
            user = move.user;
            place = move.place;
            comment = move.comment;
        }

        /// <summary>
        /// Подготовка элемента таблицы ListViewItem
        /// </summary>
        /// <returns></returns>
        public ListViewItem GetListItem()
        {
            string[] str = { date.ToString("dd.MM.yyyy"), num, name, user, place, comment };
            ListViewItem listItem = new ListViewItem(str);
            return listItem;
        }
    }
}
