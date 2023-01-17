using System;

namespace Example10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Value ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B Value ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C Value ");
            int c = Convert.ToInt32(Console.ReadLine());
            double d = (b ^2) - (4 * a * c); //kök bulma
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("Equation Has Two Roots ");
                Console.WriteLine(x1);
                Console.WriteLine( x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The Equation Has a Root ");
                Console.WriteLine( x);
            }
            else
            {
                Console.WriteLine(no root");
            }
        }
    }
}
