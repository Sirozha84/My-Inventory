using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Inventory
{
    class Item
    {
        public string Number;
        public string Name;

        public Item(string Number, string Name)
        {
            this.Number = Number;
            this.Name = Name;
        }
    }
}
