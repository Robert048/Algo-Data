using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class LinearHash<T>
    {
        private int size;
        private ArrayList[] data;

        public LinearHash(int size)
        {
            this.size = size;
            data = new ArrayList[size];
        }

        public void Output()
        {
            for (int i = 0; i < data.Count(); i++)
            {
                if (data[i] != null)
                {
                    Console.WriteLine(data[i].ToString());
                }
            }
        }

        public int HashFunction(int key)
        {
            return key % size;
        }

        public void Insert(T item)
        {
            
        }
    }
}
