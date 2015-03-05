using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inf2c;

namespace inf2cConsole
{
    class BinarySearchTest
    {
        public BinarySearchTest()
        {
            var testArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            // search for 2 in testArray
            int indexFound = BinarySearch.binSearch(2, testArray);
            Console.WriteLine("[BinarySearch] 2 found at index: " + indexFound);

        }

    }
}
