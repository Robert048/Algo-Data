﻿using System;
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
            SequentialSearchTest sequentialTest = new SequentialSearchTest();

            // dont close the console
            MinMaxTest MinMax = new MinMaxTest();
            Console.ReadLine();
        }
    }
}
