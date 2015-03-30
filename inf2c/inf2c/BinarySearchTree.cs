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

        public NodeBin<T> GetSuccessor(NodeBin<T> delNode) { NodeBin<T> successorParent = delNode;
NodeBin<T> successor = delNode;
NodeBin<T> current = delNode.Right;
while (!(current == null)) { successorParent = current; successor = current; current = current.Left;
}if (!(successor == delNode.Right)) { successorParent.Left = successor.Right; successor.Right = delNode.Right;
}return successor; }

        public NodeBin<T> Find(int key)
        {
            NodeBin<T> current = root;
            while (current.Data != key)
            {
                if (key < current.Data)
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
while (current.Data != key) { parent = current;
if (key < current.Data) {
       isLeftChild = true;
current = current.Right; } else {
       isLeftChild = false;
       current = current.Right;
}
    if (current == null)
           return false;
    }if ((current.Left == null) && (current.Right == null)) if (current == root)
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
 else{
        NodeBin<T> successor = GetSuccessor(current);
      if (current == root)
                  root = successor;
         else if (isLeftChild)
            parent.Left = successor;

         else
            parent.Right = successor;
         successor.Left = current.Left;
}
        return true; }
        //    bool isLeftChild = true;
        //    while (current.Data != key)
        //    {
        //        parent = current;
        //        if (key < current.Data)
        //        {
        //            isLeftChild = true;
        //            current = current.Right;
        //        }
        //        else
        //        {
        //            isLeftChild = false;
        //            current = current.Right;
        //        }
        //        if (current == null)
        //            return false;
        //    }
        //    if ((current.Left == null) & (current.Right == null))
        //    {
        //        if (current == root)

        //            root = null;
        //        else if (isLeftChild)
        //            parent.Left = null;
        //        else
        //            parent.Right = null;
        //    }
        //    return true;
        //}
        
                
            
        

     // the rest of the class goes here


        public int FindMin()
        {
            NodeBin<T> current = root;
            while (!(current.Left == null))
                current = current.Left;
            return current.Data;
        }

        public int FindMax()
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

        public void Insert(int i)
        {
            NodeBin<T> newNode = new NodeBin<T>();
            newNode.Data = i;
            if (root == null)
            
                root = newNode;
            
            else
            {
                NodeBin<T> current = root;
                NodeBin<T> parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
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
    }
}
