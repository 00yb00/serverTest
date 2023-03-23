using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item
    {
        public string name { get; set; }
        public int amount { get; set; }
        public Item()
        {

        }
        public Item(string name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }

    }
}
