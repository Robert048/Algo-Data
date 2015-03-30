using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2c
{
    public class BinarySearchTree<T>where T : IComparable
    {
        public NodeBin<T> root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void InOrder(NodeBin<T> theRoot)
        {
            if (!(theRoot == null))
            {
                InOrder(theRoot.left);
                theRoot.DisplayNode();
                InOrder(theRoot.right);
            }
        }

        public void preOrder(NodeBin<T> theRoot)
        {
            if (!(theRoot == null))
            {
                theRoot.DisplayNode();
                preOrder(theRoot.left);
                preOrder(theRoot.right);
            }
        }

        public void PostOrder(NodeBin<T> theRoot)
        {
            if (!(theRoot == null))
            {
                PostOrder(theRoot.left);
                PostOrder(theRoot.right);
                theRoot.DisplayNode();
            }
        }

        public void Insert(int i)
        {
            NodeBin<T> newNode = new NodeBin<T>();
            newNode.data = i;
            if (root == null)
            
                root = newNode;
            
            else
            {
                NodeBin<T> current = root;
                NodeBin<T> parent;
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
                        //else
                        //{
                        //    current = current.left;
                        //}
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }

                    }
                }
            }
        }
    }
}
