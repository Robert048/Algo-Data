using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inf2cConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "inf2c dll";

            //duidelijk console kleuren
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            // starting the query performance counter
            inf2c.Timing timing = new inf2c.Timing();
            timing.Start();


            //Sorting
            InsertionSortTest insertionSort = new InsertionSortTest();
            BubbleSortTest bubbleSort = new BubbleSortTest();

            //Search
            SequentialSearchTest sequentialTest = new SequentialSearchTest();
            BinarySearchTest binarySearchTest = new BinarySearchTest();
            MinMaxTest MinMax = new MinMaxTest();
            BinarySearchTreeTest binarySearchTree = new BinarySearchTreeTest();


            // stack and queue
            CustomStackTest customStackTest = new CustomStackTest();
            CustomQueueTest customQueueTest = new CustomQueueTest();
            PriorityQueueTest priorityQueueTest = new PriorityQueueTest();

            LinkedListTest linkedListTest = new LinkedListTest();
            GenericLinkedListTest genericLinkedListTest = new GenericLinkedListTest();

            // Hashing
            BucketHashTest bucketHashTest = new BucketHashTest();
            LinearHashTest linearHashTest = new LinearHashTest();
            QuadraticHashTest quadraticHashTest = new QuadraticHashTest();

            // Doubly!
            DoublyLinkedListTest doublyLinkedListTest = new DoublyLinkedListTest();

            timing.Stop();
            Console.WriteLine("TIMER TIME: " + timing.Duration);

            // dont close the console
            Console.ReadLine();
        }
    }
}
