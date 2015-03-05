using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// RecursiveBinarySearch using generics to search for a value in arrays
    /// Loop through the array with a Lowest and Highest number to search for the middle, until 
    /// the value is found. Recursive means: Returning the method itself, self running code.
    /// </summary>
    public class RecursiveBinarySearch
    {
        /// <summary>
        /// T must implement the interface IComparable
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">The array to search the given value</param>
        /// <param name="value">The value to search in the given array</param>
        /// <param name="lower">The Lowest number in the array</param>
        /// <param name="upper">The Highest number in the array</param>
        /// <returns>The found position or -1 if nothing was found</returns>
        public static int RbinSearch<T>(T[] arr, T value, int lower, int upper) where T : IComparable
        {
            // If lower is higher than upper, return -1 (Nothing was found).
            if (lower > upper)
                return -1;
            // Start looping through
            else
            {
                // Calculating the middle of Upper and Lower
                int mid;
                mid = (int)(upper + lower) / 2;
                // When the calculated middle is higher than the value, decrement mid.
                if (arr[mid].CompareTo(value) > 0)
                {
                    return RbinSearch(arr, value, lower, mid - 1);
                }
                // When the calculated middle equals the value, return middle.
                else if (arr[mid].CompareTo(value) == 0)
                {
                    return mid;
                }
                // When the calculated middle is smaller than the value, increment mid.
                else
                {
                    return RbinSearch(arr, value, mid + 1, upper);
                }
            }
        }
    }
}