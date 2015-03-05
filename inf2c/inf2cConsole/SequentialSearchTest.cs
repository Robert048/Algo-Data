using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    class SequentialSearchTest
    {
        public SequentialSearchTest()
        {
            var testArray = new int[] { 1, 3, 5, 9, 29, 19, 2, 10, 203, 1, 3, 1 };

            // search for 29 in testArray
            int indexFound = SequentialSearch.SeqSearch<int>(testArray, 29);
            Console.WriteLine("29 found at index: " + indexFound);
            // search for 4 in testArray
            indexFound = SequentialSearch.SeqSearch<int>(testArray, 4);
            Console.WriteLine("4 found at index: " + indexFound);

            // Occurrence 2 with value 1
            indexFound = SequentialSearch.SeqSearchOccurrence<int>(testArray, 1, 2);
            Console.WriteLine("1 with occurrence 2 found at index: " + indexFound);

        }
    }
}
