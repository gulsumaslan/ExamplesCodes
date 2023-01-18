using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number= Convert.ToInt32(Console.ReadLine());
            if (number>0)
            {
                Console.WriteLine("number is positive");

            }
            else if (number<0)
            {
                Console.WriteLine("number is negative");
            }
            else
            {
                Console.WriteLine("number is 0");
            }
        }
    }
}
