using System;
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
            SequentialSearchTest sequentialTest = new SequentialSearchTest();
            BinarySearchTest binarySearchTest = new BinarySearchTest();

            // dont close the console
            Console.ReadLine();
        }
    }
}
