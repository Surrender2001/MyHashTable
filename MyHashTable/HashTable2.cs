using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class HashTable2<TKey,TValue>
    {
        private List<TValue>[] items;
        public HashTable2(int size)
        {
            items = new List<TValue>[size];
        }
        public void Add(TKey key, TValue value)
        {
            var k = GetHash(key);
            if (items[k]==null)
            {
                items[k] = new List<TValue>() { value };
            }
            else
            {
                items[k].Add(value);
            }
            
        }
        public bool Search(TKey key, TValue value)
        {
            var k = GetHash(key);
            return items[k]?.Contains(value)??false;

        }

        private int GetHash(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));
        }




    }
}
