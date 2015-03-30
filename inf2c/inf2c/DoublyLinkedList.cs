using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// DLL Stands for "DoublyLinkedList"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericNodeDLL<T> where T : IComparable
    {
        public T Element;
        public GenericNodeDLL<T> Flink;
        public GenericNodeDLL<T> Blink;

        /// <summary>
        /// Flink refers to the link to the next node, Blink refers to the link to the previous node.
        /// </summary>
        public GenericNodeDLL()
        {
            Flink = null;
            Blink = null;
        }
        public GenericNodeDLL(T theElement)
        {
            Element = theElement;
            Flink = null;
            Blink = null;
        }
    }

    public class DoublyLinkedList<T> where T : IComparable
    {
        private GenericNodeDLL<T> header;
        private GenericNodeDLL<T> last;

        public DoublyLinkedList()
        {
            header = null;
            last = null;
        }


        public GenericNodeDLL<T> Find(T item)
        {
            GenericNodeDLL<T> current = new GenericNodeDLL<T>();
            current = header;
            while (!object.Equals(current.Element, item) && current.Flink != null)
            {
                current = current.Flink;
            }
            return current;
        }

        private GenericNodeDLL<T> FindLast()
        {
            GenericNodeDLL<T> current = new GenericNodeDLL<T>();
            current = header;
            while (!(current.Flink == null))
                current = current.Flink;
            return current;
        }

        public void Insert(T newItem, T after)
        {
            GenericNodeDLL<T> current = new GenericNodeDLL<T>();
            GenericNodeDLL<T> newNode = new GenericNodeDLL<T>(newItem);
            current = Find(after);
            newNode.Flink = current.Flink;
            newNode.Blink = current;
            current.Flink = newNode;
        }

        public void InsertFirst(T newItem)
        {
            GenericNodeDLL<T> n = new GenericNodeDLL<T>();
            n.Element = newItem;
            n.Flink = null;

            if (last == null)
            {
                header = n;
                last = n;
            }
            else
            {
                last.Flink = n;
                last = n;
            }
        }

        public void InsertLast(T newItem)
        {
            GenericNodeDLL<T> n = new GenericNodeDLL<T>();
            n.Element = newItem;
            n.Blink = null;

            if (last == null)
            {
                header = n;
                last = n;
            }
            else
            {
                last.Blink = n;
                last = n;
            }
        }

        public void Remove(T n)
        {
            GenericNodeDLL<T> p = Find(n);
            if (!(p.Flink == null))
            {
                p.Blink.Flink = p.Flink;
                p.Flink.Blink = p.Blink;
                p.Flink = null;
                p.Blink = null;
            }
        }

        public void PrintList()
        {
            GenericNodeDLL<T> current = new GenericNodeDLL<T>();
            current = header;

            while (current != null)
            {
                Console.WriteLine("[LinkedListTest] " + current.Element);
                current = current.Flink;
            }
        }

        public void PrintReverse()
        {
            GenericNodeDLL<T> current = new GenericNodeDLL<T>();
            current = FindLast();
            while (!(current.Blink == null))
            {
                Console.WriteLine(current.Element);
                current = current.Blink;
            }
        }

    }
}
