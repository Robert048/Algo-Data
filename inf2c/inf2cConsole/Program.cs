﻿using System;
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

            // stack and queue
            CustomStackTest customStackTest = new CustomStackTest();
            CustomQueueTest customQueueTest = new CustomQueueTest();
            PriorityQueueTest priorityQueueTest = new PriorityQueueTest();

            LinkedListTest linkedListTest = new LinkedListTest();
            GenericLinkedListTest genericLinkedListTest = new GenericLinkedListTest();

            // Hashing
            BucketHashTest bucketHashTest = new BucketHashTest();

            timing.Stop();
            Console.WriteLine("TIMER TIME: " + timing.Duration);

            // dont close the console
            Console.ReadLine();
        }
    }
}
