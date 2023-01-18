using System;

namespace Example14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current value");
            int flow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the resistance value");
            int resistance= Convert.ToInt32(Console.ReadLine());

            int Income = flow * resistance;
            Console.WriteLine(Income);
        }
    }
}
