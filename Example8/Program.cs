using System;

namespace Example8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int N = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
