using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// CustomArrayList class using arrays to store item
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    public class CustomArrayList<T>
    {
        // max size of the arraylist
        private int mMaxSize;
        // array to store items in
        private T[] items;
        // the current index
        private int temp_index;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomArrayList{T}"/> class.
        /// </summary>
        /// <param name="size">The size of the arraylist</param>
        public CustomArrayList(int size)
        {
            mMaxSize = size;
            items = new T[size];
            temp_index = 0;
        }

        /// <summary>
        /// Gets the count of items.
        /// </summary>
        /// <value>
        /// The count of items.
        /// </value>
        public int Count
        {
            get { return items.Count(); }
        }

        /// <summary>
        /// Gets the capacity of the arraylist
        /// </summary>
        /// <value>
        /// The capacity of the arraylist
        /// </value>
        public int Capacity
        {
            get { return mMaxSize; }
        }

        /// <summary>
        /// Clears all items from array
        /// </summary>
        public void Clear()
        {
            temp_index = 0;
            items = new T[mMaxSize];
        }

        /// <summary>
        /// Adds the specified item to the arraylist
        /// </summary>
        /// <param name="item">The item to add</param>
        public void Add(T item)
        {
            // if there is no item on this position
            if (items[temp_index] == null)
            {
                items[temp_index] = item;
                temp_index++;
            }
        }

        /// <summary>
        /// Adds the range to the arraylist
        /// </summary>
        /// <param name="range">The range.</param>
        public void AddRange(List<T> range)
        {
            // loop through the range
            foreach (T item in range)
            {
                // if there is no item on this position
                if (items[temp_index] == null)
                {
                    items[temp_index] = item;
                    temp_index++;
                }
            }
        }

        /// <summary>
        /// Determines whether the arraylist contains the item
        /// </summary>
        /// <param name="item">The item to check.</param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        /// <summary>
        /// Inserts the item at a specific index
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="at">At.</param>
        public void Insert(T item, int at)
        {
            items[at] = item;
        }

        /// <summary>
        /// Copies an array to new index
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        public void CopyTo(Array array, int index)
        {
            items.CopyTo(array, index);
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
