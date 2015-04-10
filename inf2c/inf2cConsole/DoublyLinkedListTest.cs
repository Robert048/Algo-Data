using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    class DoublyLinkedListTest
    {
        public DoublyLinkedListTest()
        {
            GenericNodeDLL<string> node = new GenericNodeDLL<string>("Vincent");

            DoublyLinkedList<string> names = new DoublyLinkedList<string>();
            names.InsertFirst("Mike");
            names.InsertLast("Paul");
            names.Insert("Hakob", "Mike");
            names.InsertFirst(node);
            //names.Remove("Mike");

            names.PrintList();
            names.PrintReverse();
        }
    }
}
