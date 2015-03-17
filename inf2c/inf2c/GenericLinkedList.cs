using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class GenericNode<T> where T : IComparable
    {
        public T Element;
        public GenericNode<T> Next;

        public GenericNode()
        {
            Next = null;
        }

        public GenericNode(T TheElement)
        {
            Element = TheElement;
            Next = null;
        }
    }

    public class GenericLinkedList<T> where T : IComparable
    {
        private GenericNode<T> first;
        private GenericNode<T> last;
        private int mcount;

        public GenericLinkedList()
        {
            first = null;
            last = null;
        }

        public int Count
        {
            get { return mcount; }
        }

        public GenericNode<T> Find(T item)
        {
            GenericNode<T> current = new GenericNode<T>();
            current = first;

            while (!object.Equals(current.Element, item) && current.Next != null)
            {
                current = current.Next;
            }

            return current;
        }

        public void OutputList()
        {
            GenericNode<T> node = new GenericNode<T>();
            node = first;

            while (node != null)
            {
                Console.WriteLine("[GenericLinkedListTest] " + node.Element);
                node = node.Next;
            }
        }

        public void Add(GenericNode<T> element)
        {
            GenericNode<T> n = element;
            n.Next = null;

            if (last == null)
            {
                first = n;
                last = n;
            }
            else
            {
                last.Next = n;
                last = n;
            }

            mcount++;
        }

        public void Add(T element)
        {
            GenericNode<T> n = new GenericNode<T>();
            n.Element = element;
            n.Next = null;

            if (last == null)
            {
                first = n;
                last = n;
            }
            else
            {
                last.Next = n;
                last = n;
            }

            mcount++;
        }

        public void AddAfter(T element, T afterElement)
        {
            GenericNode<T> current = new GenericNode<T>();
            GenericNode<T> newNode = new GenericNode<T>(element);

            current = Find(afterElement);

            newNode.Next = current.Next;
            current.Next = newNode;

            mcount++;
        }

        public T RemoveFirst()
        {
            T removeItem = first.Element;

            if (first == last)
            {
                first = last;
                last = null;
            }
            else
            {
                first = first.Next;
            }

            return removeItem;
        }

        public T RemoveLast()
        {
            T removeItem = last.Element;

            if (first == last)
            {
                first = last;
                last = null;
            }
            else
            {
                GenericNode<T> current = first;
                while (current.Next != last)
                {
                    current = current.Next;
                }
                last = current;
                current.Next = null;
            }

            return removeItem;
        }
    }
}