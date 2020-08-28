using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Inventory
{
    public class Move
    {
        public DateTime date;
        public string user;
        public string place;
        public string comment;

        public Move()
        {
            date = DateTime.Now;
        }

        public ListViewItem listItem()
        {
            string[] labels = { date.ToString("dd.MM.yyyy"), user, place, comment };
            return new ListViewItem(labels) { Tag = this };
        }

        public ListViewItem LogItem()
        {
            string[] labels = { date.ToString("dd.MM.yyyy"), "", "", user, place, comment };
            return new ListViewItem(labels) { Tag = this };
        }
    }
}
