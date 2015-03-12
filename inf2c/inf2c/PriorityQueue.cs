using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// Interface which is required to use PriorityQueue
    /// </summary>
    public interface IPriorityItem
    {
        int priority { get; }
        string name { get; }
    }

    /// <summary>
    /// Class PriorityQueue implements the class Queue and requires T to implement IPriorityItem interface
    /// </summary>
    /// <typeparam name="T">Any object which implements the interface IPriorityItem</typeparam>
    public class PriorityQueue<T> : Queue<T> where T : IPriorityItem
    {
        /// <summary>
        /// Constructor call the Queue class constructor with base()
        /// </summary>
        public PriorityQueue() : base() {}

        /// <summary>
        /// Override the Dequeue method from the Queue class
        /// "new" keyword overrides the Dequeue method
        /// </summary>
        /// <returns>returns the generic object</returns>
        public new T Dequeue()
        {
            // temp array
            T[] items;
            int min, minindex = 0;
            items = base.ToArray();
            // get the first item on index 0 and its priority
            min = (items[0] as IPriorityItem).priority;

            // checks for items with higher priority and set them on min
            for (int x = 1; x <= items.GetUpperBound(0); x++)
            {
                if ((items[x] as IPriorityItem).priority < min)
                {
                    min = (items[x] as IPriorityItem).priority;
                    minindex = x;
                }
            }
            // clear the array of Queue class
            base.Clear();

            // check if attribute name is empty, and x isn't minindex
            // than add it to the queue class and return the new item
            for (int x = 0; x <= items.GetUpperBound(0); x++)
            {
                if (x != minindex && (items[x] as IPriorityItem).name != "")
                    base.Enqueue(items[x]);
            }

            return items[minindex];
        }
    }
}
