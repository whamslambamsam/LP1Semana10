using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void IntCollections()
        {
            List<int> List = new List<int> {1, 10, -30, 10, -5};
            Stack<int> Stack = new Stack<int> {1, 10, -30, 10, -5};
            Queue<int> Queue = new Queue<int> {1, 10, -30, 10, -5};
            HashSet<int> HashSet = new HashSet<int> {1, 10, -30, 10, -5};

            foreach (int number in List)
            {
                Console.WriteLine(number);
            }

            foreach (int number in Stack)
            {
                Console.WriteLine(number);
            }
        }
    }
}
