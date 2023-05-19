using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] {"A","Y","V","E","A"};

            List<Program> list=array;
            Stack<Program> stack=array;
            Queue<Program> queue=array;
            HashSet<Program> hashset=array;

            foreach (string l in list)
            {
                Console.WriteLine($"{l}");
            }
            foreach (string s in stack)
            {
                Console.WriteLine($"{s}");
            }
            foreach (string q in queue)
            {
                Console.WriteLine($"{q}");
            }
            foreach (string h in hashset)
            {
                Console.WriteLine($"{h}");
            }
            
                
            

        }
    }
}
