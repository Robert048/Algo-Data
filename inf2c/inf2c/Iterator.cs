using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inf2c;

namespace inf2c
{
    public class Iterator
    {
        private Node current;
        private Node previous;
        LinkedList theList;

        public Iterator(LinkedList list)
        {
            theList = list;
            current = theList.getFirst();
            previous = null;
        }

        public void NextLink()
        {
            previous = current;
            current = current.Link;
        }

        public Node GetCurrent()
        {
            return current;
        }

        public void InsertBefore(Object theElement)
        {
            Node newNode = new Node(theElement);
            if (previous.Link == null)
            {
                throw new Node.InsertBeforeHeaderException("Can't insert here");
            }
            else
            {
                newNode.Link = previous.Link;
                previous.Link = newNode;
                current = newNode;
            }
        }

        public void InsertAfter(Object theElement)
        {
            Node newNode = new Node(theElement);
            newNode.Link = current.Link;
            current.Link = newNode;
            NextLink();
        }

        public void Remove()
        {
            previous.Link = current.Link;
        }

        public void Reset()
        {
            current = theList.getFirst();
            previous = null;
        }

        public bool AtEnd()
        {
            return (current.Link == null);
        }
    }
    
}
