using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// Queue class using List
    /// </summary>
    /// <typeparam name="T">Could be any object type</typeparam>
    public class CustomQueue<T>
    {
        // the list to store data
        private List<T> pqueue;

        /// <summary>
        /// CustomQueue constructor
        /// </summary>
        public CustomQueue()
        {
            pqueue = new List<T>();
        }

        /// <summary>
        /// Adding new item to the queue
        /// </summary>
        /// <param name="item">Item to add using generics</param>
        public void Enqueue(T item)
        {
            pqueue.Add(item);
        }

        /// <summary>
        /// Removes first added item in the queue (index 0)
        /// </summary>
        public void Dequeue()
        {
            pqueue.RemoveAt(0);
        }

        /// <summary>
        /// Get count items from the list
        /// </summary>
        public int Count
        {
            get
            {
                return pqueue.Count;
            }
        }

        /// <summary>
        /// Get the first item from queue (index 0)
        /// </summary>
        /// <returns>Item T using generics</returns>
        public T Peek()
        {
            return pqueue.ElementAt(0);
        }

        /// <summary>
        /// Removes all items from queue
        /// </summary>
        public void ClearQueue()
        {
            pqueue.Clear();
        }
    }
}
