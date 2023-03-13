using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace CollectionsAssignment
{
    class Program
    {
        static void Main()
        {
            Queue<string> QueueWithNumbers = new Queue<string>();
            QueueWithNumbers.Enqueue("first");
            QueueWithNumbers.Enqueue("second");
            QueueWithNumbers.Enqueue("third");
            QueueWithNumbers.Enqueue("forth");
            QueueWithNumbers.Enqueue("fifth");
            QueueWithNumbers.Enqueue("sixth");
            QueueWithNumbers.Enqueue("seventh");

            QueueWithNumbers.Dequeue();

            Console.WriteLine("Normal queue:");
            foreach (string number in QueueWithNumbers)
            {
                Console.WriteLine(number);
            }

            var SortedQueue = QueueWithNumbers.OrderBy(position => position);

            Console.WriteLine("\nSorted queue:");
            foreach (string number in SortedQueue)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nReverse sorted queue:");
            foreach (string number in SortedQueue.Reverse())
            {
                Console.WriteLine(number);
            }
        }
    }
}





