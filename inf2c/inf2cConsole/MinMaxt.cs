using System;
using inf2c;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2cConsole
{
    class MinMaxt
    {

        public MinMaxt()
        {

            var testArray = new int[] { 1, 3, 5, 9, 29, 19, 2, 10, 203, 1, 3, 1 };

            int min = MinMax.FindMin(testArray);
            Console.WriteLine("Minimum number in array is: " + min);

            int max = MinMax.FindMax(testArray);
            Console.WriteLine("Maximum number in array is: " + max);
        }

    }
}
