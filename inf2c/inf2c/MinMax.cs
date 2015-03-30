using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// Searching for a min and a max value in a given array
    /// </summary>
    /// <typeparam name="T">Any type of object which implements the IComparable interface</typeparam>
    public class MinMax<T> where T : IComparable
    {
        /// <summary>
        /// Find the min value in an array
        /// </summary>
        /// <param name="arr">The array to search the value in</param>
        /// <returns>The found min value</returns>
        public T FindMin(T[] arr)
        {
            T min = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // compare the current element with the min element
                if (arr[i].CompareTo(min) < 0)
                    min = arr[i];
            }

            return min;
        }

        /// <summary>
        /// Find the max value in an array
        /// </summary>
        /// <param name="arr">The array to search the value in</param>
        /// <returns>The found max value</returns>
        public T FindMax(T[] arr)
        {
            T max = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // compare the current element with the max element
                if (arr[i].CompareTo(max) > 0)
                    max = arr[i];
            }

            return max;
        }
    }
}
