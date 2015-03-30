using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class BucketHash<T>
    {
        private ArrayList[] data;

        public BucketHash(int size)
        {
            data = new ArrayList[size];

            for (int i = 0; i < size-1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }

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

        public void Insert(T item)
        {
            int hash_value = Hash(item.ToString());

            if (data[hash_value].Contains(item))
            {
                data[hash_value].Add(item);
            }
        }

        public void Remove(T item)
        {
            int hash_value = Hash(item.ToString());
            
            if (data[hash_value].Contains(item))
            {
                data[hash_value].Remove(item);
            }
        }

        public int Count
        {
            get { return data.Count(); }
        }

        public IEnumerator GetEnumerator()
        {
            return data.GetEnumerator();
        }

        public void Output()
        {
            Console.WriteLine("[BucketHashTest] " + data.Count());
        }
    }
}
