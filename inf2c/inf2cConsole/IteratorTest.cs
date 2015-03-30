using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inf2c;

namespace inf2cConsole
{
    class IteratorTest
    {
        public IteratorTest()
        {
            GenericLinkedList<string> myList = new GenericLinkedList<string>();
            Iterator<string> iter = new Iterator<string>(myList);
            try
            {
                iter.InsertAfter("David");
                iter.InsertAfter("Mike");
                iter.InsertAfter("Raymond");
                iter.InsertAfter("Bernice");
                iter.InsertAfter("Jennifer");
                iter.InsertAfter("Donnie");
                iter.InsertAfter("Michael");
                iter.InsertAfter("Terrill");
                iter.InsertAfter("Mayo");
                iter.InsertAfter("Clayton");
            }
            catch (Node.InsertBeforeHeaderException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
