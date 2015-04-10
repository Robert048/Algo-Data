using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    class LinearHashTest
    {
        public LinearHashTest()
        {
            LinearHash<int, string> linearHash = new LinearHash<int, string>(4);
            linearHash.Insert(1, "Piet");
            linearHash.Insert(2, "Paul");
            KeyValuePair<int, string> pair = new KeyValuePair<int, string>(3, "Richard");
            linearHash.Insert(pair);

            linearHash.Remove(2);

            Console.WriteLine("[LinearHashTest] There are {0} items.", linearHash.Size);
            linearHash.Output();
        }
    }
}
