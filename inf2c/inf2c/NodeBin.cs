using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class NodeBin<T>
    {
        public T Data;
        public NodeBin<T> Left;
        public NodeBin<T> Right;

        public NodeBin()
        {
            Data = default(T);
            Left = null;
            Right = null;
        }

        public void DisplayNode()
        {
            Console.Write(Data);
            Console.Write(",");
        }
    }
}
