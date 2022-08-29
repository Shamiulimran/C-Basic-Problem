using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int Number = int.Parse(Console.ReadLine());
            int remainder = 0;
            int sum = 0;
            //int temp=Number;
            while (Number!= 0)
            {
                remainder = Number % 10;
                sum = sum + remainder*remainder*remainder;
                Number = Number / 10;

            }
            //Console.WriteLine(sum);

            if (Number == sum)
            {
                Console.WriteLine("Entered Number is Armstrong Number");
            }
            else
            {
                Console.WriteLine("Entered Number is not Armstrong Number");

            }


            Console.ReadKey();
        }
    }
}
