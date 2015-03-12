using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class GenericNode<T>
    {
        public T Element;
        public GenericNode<T> Link;

        public GenericNode()
        {
        }
        //te
        public GenericNode(T theElement)
        {
            Element = theElement;
        }
    }

    public class InsertBeforeHeaderException : System.ApplicationException
    {
        public InsertBeforeHeaderException(string message) :
            base(message)
        {
        }
    }

    public class GenericLinkedList<T>
    {
        private GenericNode<T> header;

        public GenericLinkedList()
        {
            header = new GenericNode<T>("header");
        }

        public bool IsEmpty()
        {
            return (header.Link == null);
        }

        public GenericNode<T> GetFirst() {
            return header;
        }

        public void ShowList()
        {
            GenericNode<T> current = header.Link;
            while (!(current == null))
            {
                Console.WriteLine(current.Element);
                current = current.Link;
            }
        }
    }

    public class ListIter<T>
    {
        private GenericNode<T> current;
        private GenericNode<T> previous;
        private GenericLinkedList<T> theList;

        public ListIter(GenericLinkedList<T> list)
        {
            theList = list;
            current = theList.GetFirst();
            previous = null;
        }
        public void NextLink()
        {
            previous = current;
            current = current.Link;
        }
        public GenericNode<T> GetCurrent()
        {
            return current;
        }
        public void InsertBefore(T theElement)
        {
            GenericNode<T> newNode = new GenericNode<T>(theElement);
            if (previous.Link == null)
                throw new InsertBeforeHeaderException
                ("Can't insert here.");
            else
            {
                newNode.Link = previous.Link;
                previous.Link = newNode;
                current = newNode;
            }
        }
        public void InsertAfter(T theElement)
        {
            GenericNode<T> newNode = new GenericNode<T>(theElement);
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
            current = theList.GetFirst();
            previous = null;
        }
        public bool AtEnd()
        {
            return (current.Link == null);
        }
    }
}
