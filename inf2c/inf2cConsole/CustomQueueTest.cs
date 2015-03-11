using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    class CustomQueueTest
    {
        public CustomQueueTest()
        {
            CustomQueue<string> printer = new CustomQueue<string>();
            printer.Enqueue("Document 1");
            printer.Enqueue("Document 2");
            printer.Enqueue("Document 3");

            Console.WriteLine("[CustomQueueTest] Items in queue: " + printer.Count);
            printer.Dequeue();
            Console.WriteLine("[CustomQueueTest] Removed item with dequeue");
            Console.WriteLine("[CustomQueueTest] Item on index 0: " + printer.Peek());

        }
    }
}
