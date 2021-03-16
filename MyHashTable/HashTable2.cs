using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class HashTable2
    {
        const double GOLDEN_RATIO = 0.618;//золотое сечение
        private Item2[] items;//Хеш-таблица
        private int _size;//Размер


        //Конструктор с параметром
        //Формальные параметры:размер
        //Входные данные:---
        //Выходные данные:хеш-таблица
        public HashTable2(int size)
        {
            _size = size;
            items = new Item2[size];
            for (int i = 0; i < items.Length; i++)
                items[i] = new Item2(i);
        }

        //Добавление элемента в хеш-таблицу
        //Формальные параметры:ключ
        //Входные данные:хеш-таблица
        //Выходные данные:хеш-таблица
        public void Add(int item)
        {
            int key = GetHash(item);
            if(!items[key].Nodes.Contains(item))
            items[key].Nodes.add(item);
        }


        //Удаление элемента из хеш-таблицы
        //Формальные параметры:ключ
        //Входные данные:хеш-таблица
        //Выходные данные:хеш-таблица
        public void Delete(int item)
        {
            int key = GetHash(item);
            if (items[key].Nodes.Contains(item))
                items[key].Nodes.delete(item);
            else
                Console.WriteLine("Not found");
        }


        //Вывод на экран
        //Формальные параметры:ключ
        //Входные данные:хеш-таблица
        //Выходные данные:хеш-таблица
        public void Show()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"{i} row");
                items[i].Nodes.Show();
                Console.WriteLine();
            }
        }

        //Поиск элемента в хеш-таблице
        //Формальные параметры:ключ
        //Входные данные:хеш-таблица
        //Выходные данные:хеш-таблица
        public bool Search(int item)
        {
            int key = GetHash(item);
            return items[key].Nodes.Contains(item);
        }


        //Хеш-функция, метод умножения
        //Формальные параметры:ключ
        //Входные данные:хеш-таблица
        //Выходные данные:хеш-таблица
        private int GetHash(int item)
        {
            return ((int)Math.Floor(_size * (item * GOLDEN_RATIO % 1)))%_size;
        }


    }
}
