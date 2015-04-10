using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{

    /// <summary>
    /// Constructor for the Node Class.
    /// </summary>
    public class Node
    {
        public Object Element;
        public Node Link;

        /// <summary>
        /// Setting the Element and Link to nothing when instantiated.
        /// </summary>
        public Node()
        {
            Element = null;
            Link = null;
        }

        /// <summary>
        /// Assigns data to the Element member and sets the link to null.
        /// </summary>
        /// <param name="theElement">Element Object</param>
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
