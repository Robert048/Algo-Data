using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// Stack class using generics
    /// </summary>
    /// <typeparam name="T">Can be any object</typeparam>
    class CustomStuck<T> 
    {
        // custom index and using list with generics
        private int p_index;
        private List<T> list;

        /// <summary>
        /// CustomStuck constructor
        /// Creating new instance of list and set the index to -1, to the first element will be at index 0
        /// </summary>
        /// <param name="maxElements"></param>
        public CustomStuck(int maxElements)
        {
            list = new List<T>(maxElements);
            p_index = -1;
        }

        /// <summary>
        /// Returns the count of the list
        /// </summary>
        public int count
        {
            get
            {
                return list.Count;
            }
        }

        /// <summary>
        /// Adds an item to the list
        /// </summary>
        /// <param name="item">The object which is added</param>
        public void push(T item)
        {
            list.Add(item);
            p_index++;
        }

        /// <summary>
        /// Get and remove the last item on the stack, identify by p_index
        /// </summary>
        /// <returns>The removed item</returns>
        public T pop()
        {
            T tempObj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return tempObj;
        }

        /// <summary>
        /// Delete all items from list, reset p_index to -1
        /// </summary>
        public void clear()
        {
            list.Clear();
            p_index = -1;
        }

        /// <summary>
        /// Get the item by current p_index
        /// </summary>
        /// <returns>The item on position p_index</returns>
        public T peek()
        {
            return list[p_index];
        }
    }
}
