using System;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the third number");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the fourth number");
            int number4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the fifth number");
            int number5 = Convert.ToInt32(Console.ReadLine());

            int total= number1 + number2 + number3 + number4 + number5;
            double average = (number1 + number2 + number3 + number4 + number5) / 5;

            Console.WriteLine("total:"+total);
            Console.WriteLine("Average:"+average);


        }
    }
}
