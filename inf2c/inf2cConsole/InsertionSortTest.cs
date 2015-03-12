using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    class InsertionSortTest
    {
        public InsertionSortTest()
        {
            var array = new int[] { 4, 9, 1, 50, 38, 29, 2 };

            var output = new StringBuilder();

            foreach (var element in array)
                output.Append(element + ", ");

            Console.WriteLine("[InsertionSortTest] Unsorted array: " + output.ToString());

            output = new StringBuilder();
            var sortedArray = InsertionSort.InertionSort<int>(array);

            foreach (var element in sortedArray)
                output.Append(element + ", ");

            Console.WriteLine("[InsertionSortTest] Sorted array: " + output.ToString());
        }
    }
}
