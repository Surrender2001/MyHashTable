using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    class List
    {
		private class Node
		{
            public Node Next { get; set; }
            public int data { get; set; }

        };

		Node Head,Tail;
        public List()
		{
			Head = Tail=null;
		}
		public void add(int x)
		{
			Node temp = new Node();     //Добавление нового элемента в список            
			temp.Next = Head;
			temp.data = x;
			if (Head != null)
			{
				Tail.Next = temp;
				Tail = temp;
			}
			else Head = Tail = temp;

		}

        public int Count()
        {
            int size = 1;//счётчик 
            Node temp = Head; //резервный указатель на первый элемент
            if (Head == null) size = 0;
            else if (Head == Tail) size = 1;
            else while (temp != Tail)
                {
                    temp = temp.Next;
                    size++;
                }
            return size;
        }

        public bool Contains(int x)
        {
            Node temp = Head; //резервный указатель на первый элемент
            for (int i = 0; i < Count(); i++)
            {
                if (temp.data==x)
                {
                    return true;
                }
                temp = temp.Next;
            }
            
            return false;
        }

        public void Show()
        {
            Node tempHead = Head;
            int temp = Count();          
            if (Count() == 0) Console.WriteLine("no items in the list"); 
            else
                while (temp != 0)
                {
                    Console.WriteLine(tempHead.data + " "); 
                    tempHead = tempHead.Next;
                    temp--;
                }
        }

        public void delete(int x)
        {
            if (Count() == 0) Console.WriteLine("no items in the list");
            else
            {
                if (x == 0) Pop_Front();
                else if (x >= Count() || x < 0) Console.WriteLine("out of bounds of the list"); 
                else
                {
                    Node previous = Head;  //Вспомогательный указатель для удаления элемента
                    for (int i = 0; i < x - 1; i++) previous = previous.Next;

                    Node toDelete = previous.Next;  //Вспомогательный указатель для удаления элемента
                    previous.Next = toDelete.Next;
                    Tail = previous;
                }
            }
        }

        private void Pop_Front()
        {
            if (Count() == 1) { Head = Tail = null; }
            else
            {
                Node temp = Head; //Вспомогательный указатель для удаления элемента
                Head = Head.Next;
                Tail.Next = Head;
            }
        }
    }
}
