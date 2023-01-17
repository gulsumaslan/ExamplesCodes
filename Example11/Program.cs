using System;

namespace Example11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a product purchase price");
            double buying = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter a product tax price");
            double tax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter a product profit pricez");
            double snow = Convert.ToDouble(Console.ReadLine());



            double tax = buying + snow * 0.5 + snow * 1.8;

            Console.WriteLine(tax);
            //Console.WriteLine("enter a product purchase price");
            //double tax = Convert.ToDouble(Console.ReadLine());

        }
    }
}
