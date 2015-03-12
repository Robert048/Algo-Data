using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class GenericNode<T>
    {
        private GenericNode<T> next;
        private T data;

        public GenericNode(T t)
        {
            next = null;
            data = t;
        }

        public GenericNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }

    public class GenericLinkedList<T>
    {
        private GenericNode<T> head;

        public GenericLinkedList()
        {
            head = null;
        }

        public void AddHead(T t)
        {
            GenericNode<T> n = new GenericNode<T>(t);
            n.Next = head;
            head = n;
        }

        public void AddHead(GenericNode<T> t)
        {
            t.Next = head;
            head = t;
        }

        public IEnumerator<T> GetEnumerator()
        {
            GenericNode<T> current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }

        }
    }
}
