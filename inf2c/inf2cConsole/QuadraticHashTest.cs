using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    class QuadraticHashTest
    {
        public QuadraticHashTest()
        {
            QuadraticHash<int, string> quadraticHash = new QuadraticHash<int, string>(4);
            quadraticHash.Insert(1, "Piet");
            quadraticHash.Insert(2, "Paul");
            KeyValuePair<int, string> pair = new KeyValuePair<int, string>(3, "Richard");
            quadraticHash.Insert(pair);

            quadraticHash.Remove(2);

            Console.WriteLine("[QuadraticHashTest] There are {0} items.", quadraticHash.Size);
            quadraticHash.Output();
        }
    }
}
