using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    class GenericLinkedListTest
    {
        public GenericLinkedListTest()
        {
            GenericNode<string> node = new GenericNode<string>("Johan");

            GenericLinkedList<string> names = new GenericLinkedList<string>();
            names.Add("Mike");
            names.Add("Paul");
            names.AddAfter("Piet", "Mike");
            names.Add(node);

            names.OutputList();
        }
    }
}
