using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class NodeBin
    {
        public int data;
        public NodeBin left;
        public NodeBin right;

        public void DisplayNode()
        {
            Console.WriteLine(data);
        }

    }
}
