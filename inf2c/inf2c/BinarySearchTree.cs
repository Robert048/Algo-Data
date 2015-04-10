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

        public NodeBin<T> GetSuccessor(NodeBin<T> delNode)
        {
            NodeBin<T> successorParent = delNode;
            NodeBin<T> successor = delNode;
            NodeBin<T> current = delNode.Right;

            while (!(current == null))
            {
                successorParent = current;
                successor = current;
                current = current.Left;
            }
            if (!(successor == delNode.Right))
            {
                successorParent.Left = successor.Right;
                successor.Right = delNode.Right;
            }
            return successor;
        }

        public NodeBin<T> Find(int key)
        {
            NodeBin<T> current = root;
            while (current.Data.CompareTo(key) == -1 || current.Data.CompareTo(key) == 1)
            {
                if (key.CompareTo(current.Data) == -1)
                    current = current.Left;
                else
                {
                    current = current.Right;
                }
                if (current == null)
                    return null;
            } return current;
        }

        public bool Delete(T value)
        {
            if (root == null)
                return false;
            else
            {
                if (root.Data.CompareTo(value) == 0)
                {
                    NodeBin<T> auxRoot = new NodeBin<T>();
                    auxRoot.Left = root;
                    bool result = root.remove(value, auxRoot);
                    root = auxRoot.Left;
                    auxRoot.Left = root;
                    return result;
                }
                else
                {
                    return root.remove(value, null);
                }
            }
        }

        public T FindMin()
        {
            NodeBin<T> current = root;
            while (!(current.Left == null))
                current = current.Left;
            return current.Data;
        }

        public T FindMax()
        {
            NodeBin<T> current = root;
            while (!(current.Right == null))
                current = current.Right;
            return current.Data;
        }

        public void InOrder(NodeBin<T> theRoot)
        {
            if (!(theRoot == null))
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }

        public void preOrder(NodeBin<T> theRoot)
        {
            if (!(theRoot == null))
            {
                theRoot.DisplayNode();
                preOrder(theRoot.Left);
                preOrder(theRoot.Right);
            }
        }

        public void PostOrder(NodeBin<T> root)
        {
            if (!(root == null))
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                root.DisplayNode();
            }
        }

        public void Insert(T value)
        {
            NodeBin<T> newNode = new NodeBin<T>();
            newNode.Data = value;

            if (root == null)
                root = newNode;       
            else
            {
                NodeBin<T> current = root;
                NodeBin<T> parent;
                while (true)
                {
                    parent = current;
                    if (value.CompareTo(current.Data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                        //else
                        //{
                        //    current = current.left;
                        //}
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void Output()
        {
        }
    }
}
