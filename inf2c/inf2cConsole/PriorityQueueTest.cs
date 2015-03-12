using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using inf2c;

namespace inf2cConsole
{
    /// <summary>
    /// Test class which implements the interface IPriorityItem
    /// </summary>
    class Student : IPriorityItem
    {
        private int mpriority;
        private string mname;
        
        public Student(string name, int priority)
        {
            mpriority = priority;
            mname = name;
        }

        public int priority
        {
            get { return mpriority; }
        }

        public string name
        {
            get { return mname; }
        }
    }

    class PriorityQueueTest
    {
        public PriorityQueueTest()
        {
            Student student1 = new Student("Paul", 2);
            Student student2 = new Student("Piet", 1);
            Student student3 = new Student("Johan", 3);

            PriorityQueue<Student> queue = new PriorityQueue<Student>();
            queue.Enqueue(student1);
            queue.Enqueue(student2);
            queue.Enqueue(student3);

            Console.WriteLine("[PriorityQueueTest] Items in queue: " + queue.Count);

            Student dequeueStudent = queue.Dequeue();
            Console.WriteLine("[PriorityQueueTest] Dequeue NAME: " + dequeueStudent.name + " PRIORITY: " + dequeueStudent.priority);
        }
    }
}
