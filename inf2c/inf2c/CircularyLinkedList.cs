using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class CircularyLinkedList<T> where T : IComparable
    {
        //fields
        public GenericNode<T> current;
        public GenericNode<T> header;
        private int count;

        /// <summary>
        /// constructor for circulary linked list
        /// </summary>
        public CircularyLinkedList()
        {
            count = 0;
            
            header = new GenericNode<T>();
            header.Next = header;
        }

        /// <summary>
        /// make the list empty
        /// </summary>
        public void MakeEmpty()
        {
            header.Next = null;
        }

        /// <summary>
        /// print the linked list
        /// </summary>
        public void PrintList()
        {
            GenericNode<T> current = new GenericNode<T>();
            current = header;
            while (current.Next.Element != null && !(current.Next.Element.ToString() == "header"))
            {
                Console.WriteLine("[CircularyLinkedList] " + current.Next.Element);
                current = current.Next;
            }
        }

        /// <summary>
        /// find the previous node
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public GenericNode<T> FindPrevious(T n)
        {
            GenericNode<T> current = header;
            while (!(current.Next == null) && current.Next.Element.CompareTo(n) == 0)
            {
                current = current.Next;
            }
            return current;
        }

        /// <summary>
        /// find a node
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public GenericNode<T> Find(T n)
        {
            GenericNode<T> current = new GenericNode<T>();
            current = header.Next;
            while ((current.Next == null) && current.Element.CompareTo(n) == 0)
            {
                current = current.Next;
            }
            return current;
        }

        /// <summary>
        /// remove a node
        /// </summary>
        /// <param name="n"></param>
        public void Remove(T n)
        {
            GenericNode<T> current = FindPrevious(n);
            if(!(current.Next == null))
            {
                current.Next = current.Next.Next;
                count--;
            }
        }

        /// <summary>
        /// insert a node
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        public void Insert(T n1, T n2)
        {
            GenericNode<T> current = new GenericNode<T>();
            GenericNode<T> newNode = new GenericNode<T>(n1);
            current = Find(n2);
            newNode.Next = current.Next;
            current.Next = newNode;
            count++;
        }

        /// <summary>
        /// insert a node in the first position
        /// </summary>
        /// <param name="n"></param>
        public void InsertFirst(T n)
        {
            GenericNode<T> current = new GenericNode<T>(n);
            current.Next = header;
            header.Next = current;
            count++;
        }

        /// <summary>
        /// search a node with a number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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
