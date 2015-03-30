using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class NodeBin<T>
    {
        public int data;
        public NodeBin<T> left;
        public NodeBin<T> right;

        public void DisplayNode()
        {
            Console.Write(data);
            Console.Write(",");

        }

    }
}
