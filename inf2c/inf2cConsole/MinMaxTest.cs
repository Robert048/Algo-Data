using System;
using inf2c;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inf2c;

namespace inf2cConsole
{
    class MinMaxTest
    {

        public MinMaxTest()
        {
            MinMax<int> minMax = new MinMax<int>();

            var testArray = new int[] { 1, 3, 5, 9, 29, 19, 2, 10, 203, 1, 3, 1 };

            int min = minMax.FindMin(testArray);
            Console.WriteLine("[MinMaxSearch] Minimum number in array is: " + min);

            int max = minMax.FindMax(testArray);
            Console.WriteLine("[MinMaxSearch] Maximum number in array is: " + max);
        }

    }
}
