using System;
using System.Linq;

namespace reverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "i,love you";
            var arr = str.Split(',');
            var data = arr.OrderByDescending(x => x).ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }



            //int i;

            //for (i = arr.Length - 1; i >= 0; i--)
            //{
            //    var reverseArray = arr[i];
            //    Console.Write(reverseArray);
            //}



            Console.ReadKey();
        }
    }
}
