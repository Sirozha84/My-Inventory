using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Inventory
{
    class User
    {
        public string Name;
        public string Departament;

        public User(string Name, string Departament)
        {
            this.Name = Name;
            this.Departament = Departament;
        }

        public ListViewItem GetListVievItem()
        {
            ListViewItem item = new ListViewItem(Name);
            item.Tag = this;
            return item;
        }
    }
}
