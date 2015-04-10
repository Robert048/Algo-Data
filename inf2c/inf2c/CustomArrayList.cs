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

        public void Add(T item)
        {
            if (items[temp_index] == null)
            {
                items[temp_index] = item;
                temp_index++;
            }
        }

        public void AddRange(List<T> range)
        {
            foreach (T item in range)
            {
                if (items[temp_index] == null)
                {
                    items[temp_index] = item;
                    temp_index++;
                }
            }
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public void Insert(T item, int at)
        {
            items[at] = item;
        }

        public void CopyTo(Array array, int index)
        {
            items.CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
