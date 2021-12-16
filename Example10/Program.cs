using System;

namespace Example10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Değerini Girin ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B Değerini Girin ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C Değerini Girin ");
            int c = Convert.ToInt32(Console.ReadLine());
            double d = (b ^2) - (4 * a * c); //kök bulma
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("Denklemin İki Kökü Vardır ");
                Console.WriteLine(x1);
                Console.WriteLine( x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Denklemin Bir Kökü Vardır ");
                Console.WriteLine( x);
            }
            else
            {
                Console.WriteLine("kök yoktur");
            }
        }
    }
}
