using System;

namespace MyHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of hash table");
            int size = int.Parse(Console.ReadLine());

            var hashTable = new HashTable2(size);
            int variant;
            int item;
             while (true)
            {
                Console.WriteLine("1-add, 2-delete, 3-find, 4-show, 5-quit, default-continue");
                variant=int.Parse(Console.ReadLine());
                switch (variant)
                {
                    case 1:
                        item= int.Parse(Console.ReadLine());
                        hashTable.Add(item);
                        break;
                    case 2: 
                        item = int.Parse(Console.ReadLine());
                        hashTable.Delete(item);
                        break;
                    case 3:
                        item = int.Parse(Console.ReadLine());
                        if (hashTable.Search(item))
                            Console.WriteLine("is contained");
                        else
                            Console.WriteLine("isn't contained");
                        break;
                    case 4:
                        hashTable.Show();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        continue;
                        
                }
            }

        }
    }
}
