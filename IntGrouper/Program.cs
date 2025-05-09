using System;
using System.IO;

namespace IntGrouper
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Queue<string> files = new Queue<string> {};
            foreach (string file in args)
            {
                files.Enqueue(file);
            }

            foreach (string txt in Queue)
            {
                StreamReader text = new StreamReader($"txt");
                Console.WriteLine(text);
                text.Close();
            }
        }
    }
}
