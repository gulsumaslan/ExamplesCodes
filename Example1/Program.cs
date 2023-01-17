using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1>number1)
            {
                Console.WriteLine("the big number:" + number1);
            }
            else
            {
                Console.WriteLine("the big number:"+number2);
            }
        }
    }
}
