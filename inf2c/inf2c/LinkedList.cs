using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// A LinkedList is a data structure of a group of Nodes. These Nodes together represent a sequence.
    /// </summary>
    public class LinkedList
    {
        private Node header;
        private Node last;

        public LinkedList()
        {
            header = null;
            last = null;
        }

        /// <summary>
        /// Uses the class "Node.cs"
        /// </summary>
        /// <param name="item">Inserted object to find</param>
        /// <returns></returns>
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

        /// <summary>
        /// Method to add a new Node
        /// </summary>
        /// <param name="newItem">The Node to insert</param>
        /// <param name="after">Insert the new Node after the "after"</param>
        public void Insert(Object newItem, Object after)
        {
            Node current = new Node();
            Node newNode = new Node(newItem);
            current = Find(after);

            newNode.Link = current.Link;
            current.Link = newNode;
        }

        /// <summary>
        /// Insert a Node on the first place.
        /// </summary>
        /// <param name="newItem"></param>
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

        /// <summary>
        /// Method to find the previous node.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private Node FindPrevious(Object n)
        {
            Node current = header;
            while (!(current.Link == null) && (current.Link.
            Element != n))
                current = current.Link;
            return current;
        }

        /// <summary>
        /// return the first node
        /// </summary>
        /// <returns>first node</returns>
        public Node getFirst()
        {
            return header;
        }

        /// <summary>
        /// Method to remove a node
        /// </summary>
        /// <param name="n"></param>
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
