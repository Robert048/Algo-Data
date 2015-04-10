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

        /// <summary>
        /// Using binarysearchtree
        /// </summary>
        /// <param name="delNode">Parent node</param>
        /// <returns>New node</returns>
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

        /// <summary> 
        /// Finding node in binarysearchtree
        /// </summary>
        /// <param name="key">Value that has to be found</param>
        /// <returns>found value</returns>
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

        /// <summary>
        /// Delete node
        /// </summary>
        /// <param name="value">Delete node with this value</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// Finds node with smallest number
        /// </summary>
        /// <returns>smallest number node</returns>
        public T FindMin()
        {
            NodeBin<T> current = root;
            while (!(current.Left == null))
                current = current.Left;
            return current.Data;
        }

        /// <summary>
        /// Finds node with max number
        /// </summary>
        /// <returns>largest number node</returns>
        public T FindMax()
        {
            NodeBin<T> current = root;
            while (!(current.Right == null))
                current = current.Right;
            return current.Data;
        }

        /// <summary>
        /// Sort inorder
        /// </summary>
        /// <param name="theRoot">nodes</param>
        public void InOrder(NodeBin<T> theRoot)
        {
            if (!(theRoot == null))
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }

        /// <summary>
        /// Sort preorder
        /// </summary>
        /// <param name="theRoot">nodes</param>
        public void preOrder(NodeBin<T> theRoot)
        {
            if (!(theRoot == null))
            {
                theRoot.DisplayNode();
                preOrder(theRoot.Left);
                preOrder(theRoot.Right);
            }
        }

        /// <summary>
        /// Sort postorder
        /// </summary>
        /// <param name="root">nodes</param>
        public void PostOrder(NodeBin<T> root)
        {
            if (!(root == null))
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                root.DisplayNode();
            }
        }
        
        /// <summary>
        /// Insert node
        /// </summary>
        /// <param name="value">inserted node</param>
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
    }
}
