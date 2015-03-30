using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class BinarySearchTree
    {
        public NodeBin root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void InOrder(NodeBin theRoot)
        {
            if (!(theRoot == null))
            {
                InOrder(theRoot.left);
                theRoot.DisplayNode();
                InOrder(theRoot.right);
            }
        }

        public void Insert(int i)
        {
            NodeBin newNode = new NodeBin();
            newNode.data = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                NodeBin current = root;
                NodeBin parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                        else
                        {
                            current = current.left;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                        else
                        {

                        }
                    }
                }
            }
        }
    }
}
