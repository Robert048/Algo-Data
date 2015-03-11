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
    class CustomStack<T> 
    {
        // custom index and using list with generics
        private int p_index;
        private List<T> list;

        /// <summary>
        /// Custom stuck constructor
        /// </summary>
        public CustomStack()
        {
            list = new List<T>();
            p_index = -1;
        }
        /// <summary>
        /// CustomStuck constructor with max. elements attribute
        /// Creating new instance of list and set the index to -1, to the first element will be at index 0
        /// </summary>
        /// <param name="maxElements">max elements which can be added to the list</param>
        public CustomStack(int maxElements)
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
        /// Checks if T item contains in the list
        /// </summary>
        /// <param name="item">The object in list</param>
        /// <returns>true if it contains in the list</returns>
        public bool contains(T item)
        {
            return list.Contains(item);
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
