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
        public string Date;
        public string Num;
        public string ItemName;
        public string MoveRec;
        public LogRecord(string date, string num, string name, string move)
        {
            Date = date;
            Num = num;
            ItemName = name;
            MoveRec = move;
        }

        /// <summary>
        /// Подготовка элемента таблицы ListViewItem
        /// </summary>
        /// <returns></returns>
        public ListViewItem GetListItem()
        {
            string[] str = { Date, Num, ItemName, MoveRec };
            ListViewItem listItem = new ListViewItem(str);
            listItem.Tag = this;
            return listItem;
        }

    }
}
