using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main()
        {
            List<int> List = new List<int> {1, 10, -30, 10, -5};
            Stack<int> Stack = new Stack<int> {};
            Queue<int> Queue = new Queue<int> {};
            HashSet<int> HashSet = new HashSet<int> {1, 10, -30, 10, -5};
            
            /// Adding values to Stack 
            Stack.Push(1);
            Stack.Push(10);
            Stack.Push(-30);
            Stack.Push(10);
            Stack.Push(-5);
            /// Adding values to Queue
            Queue.Enqueue(1);
            Queue.Enqueue(10);
            Queue.Enqueue(-30);
            Queue.Enqueue(10);
            Queue.Enqueue(-5);

            /// Print the values
            /// List
            Console.WriteLine("List : \n");
            foreach (int number in List)
            {
                Console.WriteLine(number);
            }

            /// Stack
            Console.WriteLine("\n");
            Console.WriteLine("Stack : \n");
            foreach (int number in Stack)
            {
                Console.WriteLine(number);
            }

            /// Queue
            Console.WriteLine("\n");
            Console.WriteLine("Queue : \n");
            foreach (int number in Queue)
            {
                Console.WriteLine(number);
            }

            /// HashSet
            Console.WriteLine("\n");
            Console.WriteLine("HashSet : \n");
            foreach (int number in HashSet)
            {
                Console.WriteLine(number);
            }
        }
    }
}
