using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    class CircularyLinkedList<T> where T : IComparable
    {
        protected GenericNode<T> current;
        protected GenericNode<T> header;
        private int count;

        public CircularyLinkedList()
        {
            count = 0;
            header = new GenericNode<T>();
            header.Next = header;
        }

        public void MakeEmpty()
        {
            header.Next = null;
        }

        public void PrintList()
        {
            GenericNode<T> current = new GenericNode<T>();
            current = header;
            while (!(current.Next.Element.ToString() == "header"))
            {
                Console.WriteLine(current.Next.Element);
                current = current.Next;
            }
        }

        public GenericNode<T> FindPrevious(T n)
        {
            GenericNode<T> current = header;
            while (!(current.Next == null) && current.Next.Element.CompareTo(n) == 0)
            {
                current = current.Next;
            }
            return current;
        }

        public GenericNode<T> Find(T n)
        {
            GenericNode<T> current = new GenericNode<T>();
            current = header.Next;
            while (current.Element.CompareTo(n) == 0)
            {
                current = current.Next;
            }
            return current;
        }

        public void Remove(T n)
        {
            GenericNode<T> current = FindPrevious(n);
            if(!(current.Next == null))
            {
                current.Next = current.Next.Next;
                count--;
            }
        }

        public void Insert(T n1, T n2)
        {
            GenericNode<T> current = new GenericNode<T>();
            GenericNode<T> newNode = new GenericNode<T>(n1);
            current = Find(n2);
            newNode.Next = current.Next;
            current.Next = newNode;
            count++;
        }

        public void InsertFirst(T n)
        {
            GenericNode<T> current = new GenericNode<T>(n);
            current.Next = header;
            header.Next = current;
            count++;
        }

        public GenericNode<T> Search(int n)
        {
            GenericNode<T> current = header.Next;
            for (int i = 0; i <= n; i++)
            {
                current = current.Next;
            }
            if (current.Element.ToString() == "header")
            {
                current = current.Next;
            }
            return current;
        }
    }
}
