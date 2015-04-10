using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// Quadratic hash key: (key + j * j) % SIZE;
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public class QuadraticHash<TKey, TValue>
    {
        private int mMaxSize;

        private int mCurrentSize;
        private TKey[] Keys;
        private TValue[] Values;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuadraticHash{TKey, TValue}"/> class.
        /// </summary>
        /// <param name="size">The size of the hash.</param>
        public QuadraticHash(int size)
        {
            mMaxSize = size;
            mCurrentSize = 0;

            Keys = new TKey[size];
            Values = new TValue[size];
        }

        /// <summary>
        /// Remove all keys and values
        /// </summary>
        public void Clear()
        {
            mCurrentSize = 0;

            Keys = new TKey[mMaxSize];
            Values = new TValue[mMaxSize];
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public int Size
        {
            get { return mCurrentSize; }
        }

        /// <summary>
        /// Hashes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        private int Hash(TKey key)
        {
            return (key.GetHashCode() % mMaxSize);
        }

        /// <summary>
        /// If the key exists than it will return true
        /// </summary>
        /// <param name="key">The key.</param>
        private bool Contains(TKey key)
        {
            return (Get(key) != null);
        }

        /// <summary>
        /// Gets the specified value by the key
        /// </summary>
        /// <param name="key">The key to search.</param>
        /// <returns>The value | null if there is no value</returns>
        public TValue Get(TKey key)
        {
            int i = Hash(key);
            int j = 1;

            // loop through all key elements and check if they are null
            while (Keys[i] != null)
            {
                // if key at "i" is the same as the parameter key, return the value at position "i"
                if (Keys[i].Equals(key))
                {
                    return Values[i];
                }

                // Set i for the next element if nothing was found
                i = (i + j * j++) % mMaxSize;
            }

            // return null if there was no entry
            return default(TValue);
        }

        /// <summary>
        /// Inserts the specified key value pair.
        /// </summary>
        /// <param name="keyValuePair">The key value pair.</param>
        public void Insert(KeyValuePair<TKey, TValue> keyValuePair)
        {
            Insert(keyValuePair.Key, keyValuePair.Value);
        }

        /// <summary>
        /// Inserts the new key and value
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        public void Insert(TKey key, TValue val)
        {
            int tmpHash = Hash(key);
            int i = tmpHash;
            int j = 1;

            do
            {
                // check if there the position is null
                if (Keys[i] != null)
                {
                    // insert the key and value
                    Keys[i] = key;
                    Values[i] = val;

                    // increment the current size
                    mCurrentSize++;
                    return;
                }
                // Check if the key already exists
                if (Keys[i].Equals(key))
                {
                    // override the old value
                    Values[i] = val;
                    return;
                }

                i = (i + j * j++) % mMaxSize;
            } while (i != tmpHash);
        }

        public void Remove(TKey key)
        {
            // Check if the exists, otherwise jump out of the method
            if (!Contains(key))
            {
                return;
            }

            int i = Hash(key);
            int j = 1;

            // Find the position of the key and delete it
            while (!key.Equals(Keys[i]))
            {
                i = (i + j * j++) % mMaxSize;
            }

            // reset the items (default(T) is equal to NULL)
            Keys[i] = default(TKey);
            Values[i] = default(TValue);

            try
            {
                // renew all the key hashes
                for (i = (i + j * j++) % mMaxSize; Keys[i] != null; i = (i + j * j++) % mMaxSize)
                {
                    // store the key and value temponary
                    TKey tmpKey = Keys[i];
                    TValue tmpValue = Values[i];

                    // reset the key and value
                    Keys[i] = default(TKey);
                    Values[i] = default(TValue);

                    // decrement the current size
                    mCurrentSize--;
                    // Insert the temp key and value
                    Insert(tmpKey, tmpValue);
                }
            }
            catch {
                // out of range exception
            }

            // decrement the removed item
            mCurrentSize--;
        }

        /// <summary>
        /// Outputs this instance.
        /// </summary>
        public void Output()
        {
            for (int i = 0; i < mMaxSize; i++)
            {
                if (Keys[i] != null && Values[i] != null)
                {
                    Console.WriteLine("[QuadraticHashTest] " + Keys.ElementAt(i) + " : " + Values.ElementAt(i));
                }
            }
        }
    }
}
