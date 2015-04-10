using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// DLL Stands for "DoublyLinkedList"
    /// This is the Generic Node class that's used within DoublyLinkedList
    /// </summary>
    /// <typeparam name="T">T for "Generics"</typeparam>
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
            // Set to nothing when a Node is instantiated.
            Flink = null;
            Blink = null;
        }

        /// <summary>
        /// Constructor with T Element as parameter
        /// </summary>
        /// <param name="theElement">T for "Generics"</param>
        public GenericNodeDLL(T theElement)
        {
            // The Node element
            Element = theElement;
            Flink = null;
            Blink = null;
        }
    }

    /// <summary>
    /// Start of DoublyLinkedList class
    /// Constructor of DoublyLinkedList
    /// </summary>
    /// <typeparam name="T">T for "Generics"</typeparam>
    public class DoublyLinkedList<T> where T : IComparable
    {
        // The Header of Next Node of this Node
        private GenericNodeDLL<T> header;
        // The Last Node
        private GenericNodeDLL<T> last;

        /// <summary>
        /// Setting the Next and Last Nodes to Nothing
        /// </summary>
        public DoublyLinkedList()
        {
            header = null;
            last = null;
        }

        /// <summary>
        /// Method to find a Node.
        /// Loops through all the elements to find the Node.
        /// </summary>
        /// <param name="item">Item you want to search for.</param>
        /// <returns>The node where was searched for.</returns>
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

        /// <summary>
        /// Method to find the last Node.
        /// </summary>
        /// <returns>The last node</returns>
        private GenericNodeDLL<T> FindLast()
        {
            GenericNodeDLL<T> current = new GenericNodeDLL<T>();
            current = header;
            while (!(current.Flink == null))
                current = current.Flink;
            return current;
        }

        /// <summary>
        /// Method to insert or add a Node.
        /// Specify after what Node you want to place the new Node.
        /// </summary>
        /// <param name="newItem">The new Node that is inserted.</param>
        /// <param name="after">The Node after which the new Node will be inserted.</param>
        public void Insert(T newItem, T after)
        {
            GenericNodeDLL<T> current = new GenericNodeDLL<T>();
            GenericNodeDLL<T> newNode = new GenericNodeDLL<T>(newItem);
            current = Find(after);
            newNode.Flink = current.Flink;
            newNode.Blink = current;
            current.Flink = newNode;
        }

        /// <summary>
        /// Method to insert a new item on the first place.
        /// </summary>
        /// <param name="newItem">The new item</param>
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

        /// <summary>
        /// Method to insert a Node on the first place.
        /// Two methods are written for InsertFirst, this one to be able to 
        /// add a Node that was created first.
        /// </summary>
        /// <param name="newItem">The Node that has to be added.</param>
        public void InsertFirst(GenericNodeDLL<T> newItem)
        {
            GenericNodeDLL<T> n = newItem;
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

        /// <summary>
        /// Method to insert an item on the last spot.
        /// </summary>
        /// <param name="newItem">the Item you wish to add/insert.</param>
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

        /// <summary>
        /// Method to remove an item or node.
        /// </summary>
        /// <param name="n">Item you wish to remove, calls to the Find method.</param>
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

        /// <summary>
        /// Method to print the DoublyLinkedList
        /// </summary>
        public void PrintList()
        {
            GenericNodeDLL<T> current = new GenericNodeDLL<T>();
            current = header;

            while (current != null)
            {
                Console.WriteLine("[DoublyLinkedListTest] " + current.Element);
                current = current.Flink;
            }
        }

        /// <summary>
        /// Method to print the DoublyLinkedList in reverse.
        /// </summary>
        public void PrintReverse()
        {
            GenericNodeDLL<T> current = new GenericNodeDLL<T>();
            current = FindLast();
            while (!(current.Blink == null))
            {
                Console.WriteLine("[DoublyLinkedListTest] " + current.Element);
                current = current.Blink;
            }
        }

    }
}
