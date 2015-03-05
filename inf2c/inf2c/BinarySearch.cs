using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class BinarySearch
    {
        /// <summary>
        /// A binary search
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="value">searched value</param>
        /// <param name="arr">arraylist with values</param>
        /// <returns>The found position or -1 if nothing was found</returns>
        public static int binSearch<T>(T value, T[] arr) where T : IComparable
        {
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                //get the middle of the arraylist
                mid = (upperBound + lowerBound) / 2;

                //compare middle to the value and return middle if they are the same
                if (arr[mid].CompareTo(value) == 0)
                {
                    return mid;
                }
                else
                {
                    //if the value is smaller than the middle
                    if (arr[mid].CompareTo(value) > 0)
                    {
                        upperBound = mid - 1;
                    }
                    //the value is bigger than the middle
                    else
                    {
                        lowerBound = mid + 1;
                    }
                }
            }
            return -1;
        }
          
       }
}
