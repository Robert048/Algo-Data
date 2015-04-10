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
                successorParent = current; successor = current; current = current.Left;
            } if (!(successor == delNode.Right))
            {
                successorParent.Left = successor.Right; successor.Right = delNode.Right;
            } return successor;
        }

        public NodeBin<T> Find(int key)
        {
            NodeBin<T> current = root;
            while (current.Data.CompareTo(key) > 0 || current.Data.CompareTo(key) < 0)
            {
                if (key.CompareTo(current.Data) < 0)
                    current = current.Left;
                else
                {
                    current = current.Right;
                }
                if (current == null)
                    return null;
            } return current;
        }

        public bool Delete(int key)
        {
            NodeBin<T> current = root;
            NodeBin<T> parent = root;
            bool isLeftChild = true;
            while (current.Data.CompareTo(key) > 0 || current.Data.CompareTo(key) < 0)
            {
                parent = current;
                if (key.CompareTo(current.Data) < 0)
                {
                    isLeftChild = true;
                    current = current.Right;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }
                if (current == null)
                    return false;
            } 
            if ((current.Left == null) && (current.Right == null)) if (current == root)
                    root = null;
                else if (isLeftChild)
                    parent.Left = null;
                else
                    parent.Right = null;
            else if (current.Right == null)
                if (current == root)
                    root = current.Left;
                else if (isLeftChild)
                    parent.Left = current.Left;
                else
                    parent.Right = current.Right;
            else if (current.Left == null)
                if (current == root)
                    root = current.Right;
                else if (isLeftChild)
                    parent.Left = parent.Right;
                else
                    parent.Right = current.Right;
            else
            {
                NodeBin<T> successor = GetSuccessor(current);
                if (current == root)
                    root = successor;
                else if (isLeftChild)
                    parent.Left = successor;

                else
                    parent.Right = successor;
                successor.Left = current.Left;
            }
            return true;
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

        public void PostOrder(NodeBin<T> theRoot)
        {
            if (!(theRoot == null))
            {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                theRoot.DisplayNode();
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
