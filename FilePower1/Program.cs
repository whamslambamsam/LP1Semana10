using System;
using System.Collections.Generic;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string> [];

            foreach (string file in args[])
            {
                queue.Enqueue(file);
                Console.WriteLine(file);
            }
        }
    }
}
