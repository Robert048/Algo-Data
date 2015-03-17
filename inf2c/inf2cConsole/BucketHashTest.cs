using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;
using System.Collections;

namespace inf2cConsole
{
    class BucketHashTest
    {
        public BucketHashTest()
        {
            BucketHash<string> names = new BucketHash<string>(4);

            names.Insert("Paul");
            names.Insert("Piet");
            names.Insert("Johan");

            names.Remove("Paul");

            names.Output();
        }
    }
}
