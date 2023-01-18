using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int m = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                if (i==m || i%m==0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
