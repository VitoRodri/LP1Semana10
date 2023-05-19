using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] {"A","Y","V","E","A"};

            List<string> list=new List<string>();
            list.AddRange(array);
            Stack<string> stack= new Stack<string>();
            stack.Push("A");
            stack.Push("Y");
            stack.Push("V");
            stack.Push("E");
            stack.Push("A");
            Queue<string> queue= new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("Y");
            queue.Enqueue("V");
            queue.Enqueue("E");
            queue.Enqueue("A");
            HashSet<string> hashset= new HashSet<string>(array);
            
            Console.WriteLine($"List");
            foreach (string l in list)
            {
                Console.WriteLine($"{l}");
            }
            Console.WriteLine($"stack");
            foreach (string s in stack)
            {
                Console.WriteLine($"{s}");
            }
            Console.WriteLine($"queue");
            foreach (string q in queue)
            {
                Console.WriteLine($"{q}");
            }
            Console.WriteLine($"hashset");
            foreach (string h in hashset)
            {
                Console.WriteLine($"{h}");
            }
            
                
            

        }
    }
}
