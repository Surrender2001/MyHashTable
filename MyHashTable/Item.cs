using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class Item
    {
        public int Key { get; set; }
        public List<int> Nodes { get; set; }

        public Item(int key)
        {
            Key = key;
            Nodes = new List<int>();
        }
    }
}
