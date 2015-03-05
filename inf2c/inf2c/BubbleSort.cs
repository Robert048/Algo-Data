using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class BubbleSort
    {

        public static T[] BubbleSorting<T>(T[] arr) where T : IComparable
        {
            int upper = arr.Length - 1;
            T temp;

            for (int outer = upper; outer >= 1; outer--) 
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner].CompareTo(arr[inner + 1]) > 0)
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
            }
            return arr;

        }
    }
}
