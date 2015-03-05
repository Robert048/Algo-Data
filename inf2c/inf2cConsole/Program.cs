using System;
using inf2c;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2cConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting
            InsertionSortTest insertionSort = new InsertionSortTest();

            SequentialSearchTest sequentialTest = new SequentialSearchTest();
            BinarySearchTest binarySearchTest = new BinarySearchTest();
            MinMaxTest MinMax = new MinMaxTest();

            // dont close the console
            Console.ReadLine();
        }
    }
}
