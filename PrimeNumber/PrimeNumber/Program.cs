using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            int i;
            int a = 0;
            int n = 6;
            for (i = 1; i <= 6; i++)
            {
                if (6 % i == 0)
                {
                    a++;
                }
            }
                if (a == 2)
                {
                    Console.WriteLine("is a     prime number");
                }
                else
                {
                    Console.WriteLine("is not a prime number");
                }
            
            Console.ReadKey();
        }
    }
}
