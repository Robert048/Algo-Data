using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// BucketHash using Generics
    /// </summary>
    /// <typeparam name="T">Random object type</typeparam>
    public class BucketHash<T>
    {
        // arraylist to store data
        private ArrayList[] data;

        /// <summary>
        /// Constructor with size parameter
        /// Create arraylists in data arraylist
        /// </summary>
        /// <param name="size">defined size for the arraylist</param>
        public BucketHash(int size)
        {
            data = new ArrayList[size];

            for (int i = 0; i < size-1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }

        /// <summary>
        /// Creating a hash
        /// This function uses Horner’s rule to computer the polynomial function
        /// </summary>
        /// <param name="s">The object to hash as a string</param>
        /// <returns>The hash as an integer</returns>
        public int Hash(string s)
        {
            long tot = 0;
            char[] charArray = s.ToCharArray();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                tot += 37 * tot + (int)charArray[i];
            }

            tot = tot % data.GetUpperBound(0);
            if (tot < 0)
            {
                tot += data.GetUpperBound(0);
            }

            return (int)tot;
        }

        /// <summary>
        /// Add new item to the data arraylist
        /// Using Hash method to get a key
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Insert(T item)
        {
            int hash_value = Hash(item.ToString());

            if (!data[hash_value].Contains(item))
            {
                data[hash_value].Add(item);
            }
        }

        /// <summary>
        /// Remove item from data arraylist
        /// Using the stored hash for the item
        /// </summary>
        /// <param name="item">The item to remove from arraylist</param>
        public void Remove(T item)
        {
            int hash_value = Hash(item.ToString());
            
            if (data[hash_value].Contains(item))
            {
                data[hash_value].Remove(item);
            }
        }

        /// <summary>
        /// Get count
        /// </summary>
        public int Count
        {
            get { return data.Count(); }
        }

        /// <summary>
        /// Output of the data in the data arraylist
        /// </summary>
        public void Output()
        {
            for (int i = 0; i < data.Count(); i++)
            {
                var innerList = (data[i] as ArrayList);

                if (innerList != null)
                {
                    foreach (T obj in innerList)
                    {
                        Console.WriteLine("[BucketHashTest] " + obj.ToString());
                    }
                }
            }
        }
    }
}
