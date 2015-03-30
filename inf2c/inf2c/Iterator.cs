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
        // fields
        private GenericNode<T> current;
        private GenericNode<T> previous;
        private GenericLinkedList<T> theList;

        /// <summary>
        /// initialize list
        /// </summary>
        /// <param name="list"></param>
        public Iterator(GenericLinkedList<T> list)
        {
            theList = list;
            current = theList.getFirst();
            previous = null;
        }

        /// <summary>
        /// go the next link
        /// </summary>
        public void NextLink()
        {
            previous = current;
            current = current.Next;
        }

        /// <summary>
        /// get the current node
        /// </summary>
        /// <returns></returns>
        public GenericNode<T> GetCurrent()
        {
            return current;
        }

        /// <summary>
        /// insert a new node before the current node
        /// </summary>
        /// <param name="theElement"></param>
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

        /// <summary>
        /// insert a new node after the gven node
        /// </summary>
        /// <param name="theElement"></param>
        public void InsertAfter(T theElement)
        {
            GenericNode<T> newNode = new GenericNode<T>(theElement);
            newNode.Next = current.Next;
            current.Next = newNode;
            NextLink();
        }

        /// <summary>
        /// remove the node from the list 
        /// </summary>
        public void Remove()
        {
            previous.Next = current.Next;
        }

        /// <summary>
        /// return to the first node
        /// </summary>
        public void Reset()
        {
            current = theList.getFirst();
            previous = null;
        }

        /// <summary>
        /// bool if the end is reached
        /// </summary>
        /// <returns></returns>
        public bool AtEnd()
        {
            return (current.Next == null);
        }
    }
    
}
