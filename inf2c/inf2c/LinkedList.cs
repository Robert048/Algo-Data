using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class LinkedList
    {
        private Node header;
        private Node last;

        public LinkedList()
        {
            header = null;
            last = null;
        }

        public Node Find(Object item)
        {
            Node current = new Node();
            current = header;
            while (!object.Equals(current.Element, item) && current.Link != null)
            {
                current = current.Link;
            }
            return current;
        }

        public void Insert(Object newItem, Object after)
        {
            Node current = new Node();
            Node newNode = new Node(newItem);
            current = Find(after);

            newNode.Link = current.Link;
            current.Link = newNode;
        }

        public void InsertFirst(Object newItem)
        {
            Node n = new Node();
            n.Element = newItem;
            n.Link = null;

            if (last == null)
            {
                header = n;
                last = n;
            }
            else
            {
                last.Link = n;
                last = n;
            }
        }

        private Node FindPrevious(Object n)
        {
            Node current = header;
            while (!(current.Link == null) && (current.Link.
            Element != n))
                current = current.Link;
            return current;
        }

        public void Remove(Object n)
        {
            Node p = FindPrevious(n);
            if (!(p.Link == null))
            p.Link = p.Link.Link;
        }

        public void PrintList()
        {
            Node current = new Node();
            current = header;

            while (current != null)
            {
                Console.WriteLine("[LinkedListTest] " + current.Element);
                current = current.Link;
            }
        }

    }
}
