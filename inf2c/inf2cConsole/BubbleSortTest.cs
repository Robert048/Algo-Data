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

            var testArray = new int[] { 1, 3, 5, 9, 29, 19, 2, 10, 203, 1, 3, 1 };
            int[] number = BubbleSort.BubbleSort<int>(testArray);

        }

    }
}
