using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// GenericNode class
    /// </summary>
    /// <typeparam name="T">Each object which implements the IComparable interface</typeparam>
    public class GenericNode<T> where T : IComparable
    {
        // The node element
        public T Element;
        // The next node of this node
        public GenericNode<T> Next;

        /// <summary>
        /// Set the next node = null
        /// </summary>
        public GenericNode()
        {
            Next = null;
        }

        /// <summary>
        /// Constructor with Element as parameter
        /// Set the next node = null
        /// </summary>
        /// <param name="TheElement">The node element</param>
        public GenericNode(T TheElement)
        {
            Element = TheElement;
            Next = null;
        }
    }

    /// <summary>
    /// GenericLinkedList class is just a linked list class with generics
    /// </summary>
    /// <typeparam name="T">Each object which implements the IComparable interface</typeparam>
    public class GenericLinkedList<T> where T : IComparable
    {
        // First and last node saved in this vars
        private GenericNode<T> first;
        private GenericNode<T> last;
        // Count of all nodes
        private int mcount;

        /// <summary>
        /// Constructor, set the first and last node = null
        /// </summary>
        public GenericLinkedList()
        {
            first = null;
            last = null;
        }

        /// <summary>
        /// Returns the count of all nodes
        /// </summary>
        public int Count
        {
            get { return mcount; }
        }

        /// <summary>
        /// Find a node. Loop throug all elements and check if it contains the item
        /// </summary>
        /// <param name="item">Item to search</param>
        /// <returns>The node which contains the item</returns>
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

        /// <summary>
        /// Method to output all elements in the linkedlist
        /// </summary>
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

        /// <summary>
        /// Add new node to the current last element
        /// </summary>
        /// <param name="element">The node to add</param>
        public void Add(GenericNode<T> element)
        {
            GenericNode<T> n = element;
            n.Next = null; // The next must be null, element is the last element now

            // If there is no last node, than set first and last = element
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

        /// <summary>
        /// Add new element to the linkedlist
        /// </summary>
        /// <param name="element">The element to add</param>
        public void Add(T element)
        {
            // create new node object and add the element
            // The next must be null, element is the last element now
            GenericNode<T> n = new GenericNode<T>();
            n.Element = element;
            n.Next = null;

            // If there is no last node, than set first and last = element
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

        /// <summary>
        /// Adds an element after another one
        /// </summary>
        /// <param name="element">The element to add</param>
        /// <param name="afterElement">The element after the new element</param>
        public void AddAfter(T element, T afterElement)
        {
            GenericNode<T> current = new GenericNode<T>();
            GenericNode<T> newNode = new GenericNode<T>(element);

            // Find the element to add after
            current = Find(afterElement);

            // set the new element
            newNode.Next = current.Next;
            current.Next = newNode;

            mcount++;
        }

        /// <summary>
        /// Removes the first element from the linkedlist
        /// </summary>
        /// <returns>The removed element</returns>
        public T RemoveFirst()
        {
            // set the item = first
            T removeItem = first.Element;

            // Check if it is the only element in the linkedlist
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

        /// <summary>
        /// Removes the last element in the linkedlist
        /// </summary>
        /// <returns>The removed element</returns>
        public T RemoveLast()
        {
            // set the element = last
            T removeItem = last.Element;

            // Check if it is the only element in the linkedlist
            if (first == last)
            {
                first = last;
                last = null;
            }
            // else set a new last element and set the current.next = null
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