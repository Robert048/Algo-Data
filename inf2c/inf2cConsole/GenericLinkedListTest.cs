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
            GenericNode<string> node = new GenericNode<string>("Vincent");

            GenericLinkedList<string> names = new GenericLinkedList<string>();
            names.Add("Mike");
            names.Add("Paul");
            names.AddAfter("Piet", "Mike");
            names.Add(node);
            names.Add("Johan");
            names.Add("Martin");

            string removedFirst = names.RemoveFirst();
            Console.WriteLine("[GenericLinkedListTest] Removed first element: " + removedFirst);
            string removedLast = names.RemoveLast();
            Console.WriteLine("[GenericLinkedListTest] Removed last element: " + removedLast);

            names.OutputList();
        }
    }
}
