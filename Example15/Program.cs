using System;

namespace Example15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number>0)
            {
                Console.WriteLine("number is positive"+number);
            }
            else
            {
                Console.WriteLine("number is negative"+number);
            }
        }
    }
}
