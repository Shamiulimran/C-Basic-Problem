using System;

namespace Encapsulation
{
    class Pin
    {
       private  int atmPIN ;//make the data type PRIVATE
        public int getReturn()
        {
            return atmPIN;
        }
        public void setValue(int pin)
        {
            atmPIN = pin;
        }
    }
    class B
    {

    }
    class Program
    {
        static void Main(string[] args)s
        {
            Pin a = new Pin();
            a.setValue(4567);
            Console.WriteLine("ATM PIN" + a.getReturn());
        }
    }
}
