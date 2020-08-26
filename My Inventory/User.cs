using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Inventory
{
    public class User
    {
        public string name;
        public string post;
        public string organisation;
        public string departament;

        public User() { }

        public User(string Name, string Post, string Organisation, string Departament)
        {
            this.name = Name;
            this.post = Post;
            this.organisation = Organisation;
            this.departament = Departament;
        }

        public ListViewItem GetListVievItem()
        {
            string[] str = { name, departament };
            ListViewItem item = new ListViewItem(str);
            item.Tag = this;
            return item;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            else
                return name.CompareTo(((User)obj).name);
        }
    }
}
