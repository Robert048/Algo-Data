using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class Node
    {
        public Object Element;
        public Node Link;
        public Node()
        {
            Element = null;
            Link = null;

        }
        public Node(Object theElement)
        {
            Element = theElement;
            Link = null;
        }

        public class InsertBeforeHeaderException : System.ApplicationException
        {
            public InsertBeforeHeaderException(string message) : base(message)
            {

            }
        }
    }
}
