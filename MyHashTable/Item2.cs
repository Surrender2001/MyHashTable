using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class Item2
    {
        public int Key { get; set; }
        public List Nodes { get; set; }

        public Item2(int key)
        {
            Key = key;
            Nodes = new List();
        }

    }
}
