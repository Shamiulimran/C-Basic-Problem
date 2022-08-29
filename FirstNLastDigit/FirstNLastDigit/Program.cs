using System;

namespace FirstNLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int  lastDigit;
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());
            lastDigit = number % 10;
            Console.WriteLine("last digit is:" + lastDigit);
            while (number >= 10)
            {
                number = number / 10;


            }
            Console.WriteLine("first digit is:" + number);

            Console.ReadKey();

        }
    }
}
