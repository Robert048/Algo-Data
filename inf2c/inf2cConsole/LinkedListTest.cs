using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    class LinkedListTest
    {
        public LinkedListTest()
        {
            LinkedList linkedList = new LinkedList();

            linkedList.InsertFirst("Piet");
            linkedList.InsertFirst("Hakob");
            linkedList.Insert("Paul", "Hakob");

            linkedList.PrintList();
        }
    }
}
