using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    /// <summary>
    /// SequentialSearch using generics to search for a value in arrays
    /// Loop throug each item in the array and search for the given value
    /// </summary>
    public class SequentialSearch
    {
        /// <summary>
        /// T must implement the interface IComparable
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">The array to search the given value</param>
        /// <param name="value">The value to search in the given array</param>
        /// <returns>The found position or -1 if nothing was found</returns>
        public static int SeqSearch<T>(T[] arr, T value) where T : IComparable
        {
            // search in the array
            for (int index = 0; index < arr.Length; index++)
            {
                // 0 = The items are equal
                if (arr[index].CompareTo(value) == 0)
                {
                    // give the index of found item back
                    return index;
                }
            }

            // return -1 if there was no match
            return -1;
        }

        /// <summary>
        /// Search for a value using the sequential search with an occurrence
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">The array to search the given value</param>
        /// <param name="value">The value to search in the given array</param>
        /// <param name="occurrence">The position/occurrence of the item to return</param>
        /// <returns>The found position or -1 if nothing was found</returns>
        public static int SeqSearchOccurrence<T>(T[] arr, T value, int occurrence) where T : IComparable
        {
            // last found position
            int tempIndex = 0;

            // search in the array
            for (int index = 0; index < arr.Length; index++)
            {
                // 0 = the items are equal
                if (arr[index].CompareTo(value) == 0)
                {
                    // increment the tempIndex
                    tempIndex++;
                    // if the tempIndex equals the occurrence, than return the index of the item
                    if (tempIndex == occurrence)
                    {
                        return index;
                    }
                }
            }

            // return -1 if there was no match
            return -1;
        }




        public static int SeqSearchSOD<T>(T[] arr, T value) where T : IComparable
        {
            // search in the array
            for (int index = 0; index < arr.Length; index++)
            {
                // 0 = The items are equal
                if (arr[index].CompareTo(value) == 0)
                {
                    int index2 = index - 1;
                    // give the index of found item back
                    Swap<T>(ref index, ref index2);
                    return index;
                }
            }

            // return -1 if there was no match
            return -1;
        }

        static void Swap<T>(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
        


    }

