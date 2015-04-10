using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class BubbleSort
    {
        /// <summary>
        /// Sorting an array with the bubble sort algorythm
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="arr">The array to sort</param>
        /// <returns></returns>
        public static T[] BubbleSorting<T>(T[] arr) where T : IComparable
        {
            // set upper
            int upper = arr.Length - 1;
            T temp;
            
            // looping through outer
            for (int outer = upper; outer >= 1; outer--) 
            {
                // looping through inner
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    // check if inner item is bigger than inner + 1
                    if (arr[inner].CompareTo(arr[inner + 1]) > 0)
                    {
                        // set temp value and increment
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
