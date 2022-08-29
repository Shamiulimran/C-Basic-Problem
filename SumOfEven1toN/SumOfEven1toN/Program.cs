using System;

namespace SumOfEven1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum=0;
            int i ;
            int number = int.Parse(Console.ReadLine());
            for ( i = 2; i <= number; i += 2)
            {
                Sum = Sum + i;
            }
            Console.WriteLine("sum is :" + Sum);
            Console.ReadKey();
        }
    }
}
