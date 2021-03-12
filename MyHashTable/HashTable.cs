using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class HashTable<T>
    {
        private Item[] items;
        public HashTable(int size)
        {
            items = new Item[size];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item(i);
            }

        }

        public void Add(int item)
        {
            int key = GetHash(item);
            items[key].Nodes.Add(item);
        }

        public bool Search(int item)
        {
            int key = GetHash(item);
            return items[key].Nodes.Contains(item);
        }

        private int GetHash(int item)
        {
            return item.GetHashCode() % items.Length;
        }


    }
}
