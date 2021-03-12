using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class HashTable<T>
    {
        private T[] items;
        public HashTable(int size)
        {
            items = new T[size];
        }
        public void Add(T item)
        {
            var key = GetHash(item);
            items[key] = item;
        }
        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Equals(item);

        }

        private int GetHash(T item)
        {
            return (item.ToString().Length)%items.Length;
        }


    }
}
