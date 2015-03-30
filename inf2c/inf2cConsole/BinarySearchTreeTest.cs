using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inf2c;

namespace inf2cConsole
{
    class BinarySearchTreeTest
    {
        public BinarySearchTreeTest()
        {
            BinarySearchTree<int> nums = new BinarySearchTree<int>();
            nums.Insert(23);
            nums.Insert(45);
            nums.Insert(16);
            nums.Insert(37);
            nums.Insert(3);
            nums.Insert(99);
            nums.Insert(22);

            Console.Write("[BinarySearchTree(PreOrder traversal):]");
            nums.preOrder(nums.root);
            Console.WriteLine(" ");

            Console.Write("[BinarySearchTree(InOrder traversal):]");
            nums.InOrder(nums.root);
            Console.WriteLine(" ");

            Console.Write("[BinarySearchTree(PostOrder traversal):]");
            nums.PostOrder(nums.root);
            Console.WriteLine(" ");

            Console.Write("[BinarySearchTree(Find Min number):]");
            Console.WriteLine(nums.FindMin());

            Console.Write("[BinarySearchTree(Find Max number):]");
            Console.WriteLine(nums.FindMax());

          //  Console.Write("[BinarySearchTree(Find Max number):]");
          //  Console.WriteLine(nums.Find(3));

            nums.Delete(3);

            Console.WriteLine("ok");

            Console.WriteLine(nums.FindMin());


        }
    }
}
