using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class HashTable2
    {
        const double GOLDEN_RATIO = 0.618;
        private Item2[] items;
        private int _size;

        public HashTable2(int size)
        {
            _size = size;
            items = new Item2[size];
            for (int i = 0; i < items.Length; i++)
                items[i] = new Item2(i);
        }

        public void Add(int item)
        {
            int key = GetHash(item);
            items[key].Nodes.add(item);
        }

        public void Delete(int item)
        {
            int key = GetHash(item);
            if (items[key].Nodes.Contains(item))
                items[key].Nodes.delete(key);
            else
                Console.WriteLine("Not found");
        }

        public void Show()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"{i} row");
                items[i].Nodes.Show();
                Console.WriteLine();
            }
        }

        public bool Search(int item)
        {
            int key = GetHash(item);
            return items[key].Nodes.Contains(item);
        }

        private int GetHash(int item)
        {
            return (int)Math.Floor(_size * (item * GOLDEN_RATIO % 1));
        }


    }
}
