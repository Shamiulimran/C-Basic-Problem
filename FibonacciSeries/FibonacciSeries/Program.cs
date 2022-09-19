using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n=int.Parse(Console.ReadLine());
            int FibnacciNumber=0;
            int FirstNumber=0;
            int SecondNumber=1;
            
            Console.WriteLine("Fibonacci Series:");
            for (i = 0; i < n; i++)

               

            {
                    FibnacciNumber = FirstNumber + SecondNumber;
                    FirstNumber = SecondNumber;
                    SecondNumber = FibnacciNumber;
             
                Console.WriteLine("{0} ",FirstNumber,SecondNumber);

            }
           





            Console.ReadKey();
        }
    }
}
