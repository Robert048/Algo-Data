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
            Console.WriteLine("gagasdg");
            BinarySearchTree nums = new BinarySearchTree();
            nums.Insert(9);
           // nums.Insert(45);
           // nums.Insert(16);
           // nums.Insert(37);
            nums.Insert(3);
           // nums.Insert(99);
            nums.Insert(8);
            nums.Insert(1);

            Console.WriteLine("Inorder traversal:"); 
            nums.InOrder(nums.root);
        }
    }
}
