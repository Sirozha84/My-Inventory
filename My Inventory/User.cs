using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Inventory
{
    class User : IComparable
    {
        public string Name;
        public string Post;
        public string Organisation;
        public string Departament;

        public User(string Name, string Post, string Organisation, string Departament)
        {
            this.Name = Name;
            this.Post = Post;
            this.Organisation = Organisation;
            this.Departament = Departament;
        }

        public ListViewItem GetListVievItem()
        {
            string[] str = { Name, Departament };
            ListViewItem item = new ListViewItem(str);
            item.Tag = this;
            return item;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            else
                return Name.CompareTo(((User)obj).Name);
        }
    }
}
