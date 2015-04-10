using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class NodeBin<T> where T : IComparable
    {
        public T Data;
        public NodeBin<T> Left;
        public NodeBin<T> Right;

        /// <summary>
        /// Create nodebin
        /// </summary>
        public NodeBin()
        {
            Data = default(T);
            Left = null;
            Right = null;
        }

        /// <summary>
        /// Remove node 
        /// </summary>
        /// <param name="value">Value of node</param>
        /// <param name="parent">Tree</param>
        /// <returns>true or false</returns>
        public bool remove(T value, NodeBin<T> parent)
        {
            if (value.CompareTo(Data) < 0)
            {
                if (Left != null)
                    return Left.remove(value, this);
                else
                    return false;
            }
            else if (value.CompareTo(Data) > 0)
            {
                if (Right != null)
                    return Right.remove(value, this);
                else
                    return false;
            }
            else
            {
                if (Left != null && Right != null)
                {
                    this.Data = Right.minValue();
                    Right.remove(this.Data, this);
                }
                else if (parent.Left == this)
                {
                    parent.Left = (Left != null) ? Left : Right;
                }
                else if (parent.Right == this)
                {
                    parent.Right = (Left != null) ? Left : Right;
                }
                return true;
            }
        }

        /// <summary>
        /// Finding min node
        /// </summary>
        /// <returns>min node</returns>
        public T minValue()
        {
            if (Left == null)
                return Data;
            else
                return Left.minValue();
        }

        /// <summary>
        /// Displaying node(s) in console 
        /// </summary>
        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }
}
