using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    class CustomStackTest
    {
        public CustomStackTest()
        {
            CustomStack<int> stack = new CustomStack<int>();
            
            for (int i = 0; i < 100; i++)
            {
                stack.push(i);
            }

            Console.WriteLine("[CustomStackTest] Item count: " + stack.count);
            Console.WriteLine("[CustomStackTest] Last item: " + stack.pop().ToString());
        }
    }
}
