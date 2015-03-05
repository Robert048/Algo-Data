using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    class BinarySearch
    {
        static void Main(string[] args)
        {   
          Random random = new Random();
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int value = binSearch(5, arr);
            Console.WriteLine(value);
            Console.WriteLine("Done");
            Console.Read();
        }


        static int binSearch(int value, int[] arr)
        {
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                if (arr[mid] == value)
                {
                    return mid;
                }
                else
                {
                    if (value < arr[mid])
                    {
                        upperBound = mid - 1;
                    }
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
