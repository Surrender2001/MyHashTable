using System;

namespace MyHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var HashTable = new HashTable2<int,string>(100);
            HashTable.Add(5,"привет");
            HashTable.Add(18,"мир");
            HashTable.Add(777,"здравствуй");
            Console.WriteLine(HashTable.Search(6,"Вася"));
            Console.WriteLine(HashTable.Search(18,"мир"));


        }
    }
}
