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
        int action;     //0 - не используется, 1 - "пришёл от", 2 - "ушёл к"
        public LogRecord(Item item, Move move, string lastUser, string lastPlace)
        {
            date = move.date;
            num = item.number;
            name = item.name + " " + item.model;
            user = move.user;
            if (lastUser != "") user = lastUser + " -> " + user;
            place = move.place;
            if (lastPlace != "") place = lastPlace + " -> " + place;
            comment = move.comment;
        }

        public LogRecord(Item item, Move move, int action, string user, string place)
        {
            date = move.date;
            num = item.number;
            name = item.name + " " + item.model;
            this.action = action;
            this.user = user;
            this.place = place;
            comment = move.comment;
        }

        /// <summary>
        /// Подготовка элемента таблицы ListViewItem для общего журнала перемещений
        /// </summary>
        /// <returns></returns>
        public ListViewItem GetListItemLog()
        {
            string[] str = { date.ToString("dd.MM.yyyy"), num, name, user, place, comment };
            ListViewItem listItem = new ListViewItem(str);
            return listItem;
        }

        /// <summary>
        /// Подготовка элемента таблицы ListViewItem для истории сотрудника
        /// </summary>
        /// <returns></returns>
        public ListViewItem GetListItemUserHistory()
        {
            string act = "";
            if (action == 1) act = "Пришёл от";
            if (action == 2) act = "Ушёл к";
            //if (action == 3) act = "Ремонт...";
            string[] str = { date.ToString("dd.MM.yyyy"), num, name, act, user, place, comment };
            ListViewItem listItem = new ListViewItem(str);
            return listItem;
        }
    }
}
