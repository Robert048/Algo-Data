using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inf2c;

namespace inf2cConsole
{
    class BubbleSortTest
    {
        public BubbleSortTest()
        {
            var array = new int[] { 4, 9, 1, 50, 38, 29, 2, 5, 644, 453, 234 };
            var sortedArray = BubbleSort.BubbleSorting<int>(array);

            var array2 = new int[] { 4, 9, 1, 50, 38, 29, 2, 5, 644, 453, 234 };
            var output = new StringBuilder();


            foreach (var element in array2)
                output.Append(element + ", ");

            Console.WriteLine("[BubbleSort] Unsorted array: " + output.ToString());

            output.Clear();

            foreach (var element in sortedArray)
                output.Append(element + ", ");

            Console.WriteLine("[BubbleSort] Sorted array: " + output.ToString());
        }


    }
}
