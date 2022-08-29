using System;
using System.Collections.Generic;

namespace StackCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            Stack<int> mystack = new Stack<int>(arr);
            foreach(var i in mystack)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();        }
    }
}
