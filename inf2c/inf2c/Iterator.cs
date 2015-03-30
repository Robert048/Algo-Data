using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inf2c;

namespace inf2c
{
    public class Iterator<T> where T : IComparable
    {
        private GenericNode<T> current;
        private GenericNode<T> previous;
        private GenericLinkedList<T> theList;

        public Iterator(GenericLinkedList<T> list)
        {
            theList = list;
            current = theList.getFirst();
            previous = null;
        }

        public void NextLink()
        {
            previous = current;
            current = current.Next;
        }

        public GenericNode<T> GetCurrent()
        {
            return current;
        }

        public void InsertBefore(T theElement)
        {
            GenericNode<T> newNode = new GenericNode<T>(theElement);
            if (previous.Next == null)
            {
                throw new Node.InsertBeforeHeaderException("Can't insert here");
            }
            else
            {
                newNode.Next = previous.Next;
                previous.Next = newNode;
                current = newNode;
            }
        }

        public void InsertAfter(T theElement)
        {
            GenericNode<T> newNode = new GenericNode<T>(theElement);
            newNode.Next = current.Next;
            current.Next = newNode;
            NextLink();
        }

        public void Remove()
        {
            previous.Next = current.Next;
        }

        public void Reset()
        {
            current = theList.getFirst();
            previous = null;
        }

        public bool AtEnd()
        {
            return (current.Next == null);
        }
    }
    
}
