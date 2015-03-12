using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class GenericNode<T> where T : IComparable
    {
        public object Element;
        public GenericNode<T> Link;

        public GenericNode()
        {
            Element = null;
            Link = null;
        }

        public GenericNode(T TheElement)
        {
            Element = TheElement;
            Link = null;
        }
    }

    public class GenericLinkedList<T> where T : IComparable
    {
        private GenericNode<T> head;
        private GenericNode<T> last;
        private int mcount;

        public GenericLinkedList()
        {
            head = null;
            last = null;
        }

        public int Count
        {
            get { return mcount; }
        }

        public GenericNode<T> Find(T item)
        {
            GenericNode<T> current = new GenericNode<T>();
            current = head;

            while (!object.Equals(current.Element, item) && current.Link != null)
            {
                current = current.Link;
            }

            return current;
        }

        public void OutputList()
        {
            GenericNode<T> node = new GenericNode<T>();
            node = head;

            while (node != null)
            {
                Console.WriteLine("[GenericLinkedListTest] " + node.Element);
                node = node.Link;
            }
        }

        public void Add(GenericNode<T> element)
        {
            GenericNode<T> n = element;
            n.Link = null;

            if (last == null)
            {
                head = n;
                last = n;
            }
            else
            {
                last.Link = n;
                last = n;
            }

            mcount++;
        }

        public void Add(T element)
        {
            GenericNode<T> n = new GenericNode<T>();
            n.Element = element;
            n.Link = null;

            if (last == null)
            {
                head = n;
                last = n;
            }
            else
            {
                last.Link = n;
                last = n;
            }

            mcount++;
        }

        public void AddAfter(T element, T afterElement)
        {
            GenericNode<T> current = new GenericNode<T>();
            GenericNode<T> newNode = new GenericNode<T>(element);

            current = Find(afterElement);

            newNode.Link = current.Link;
            current.Link = newNode;

            mcount++;
        }
    }
}