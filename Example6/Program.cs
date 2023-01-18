using System;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a price");
            double price = Convert.ToDouble(Console.ReadLine());
            double kdv = price * 0.18;
            double total = price +kdv;
            Console.WriteLine(total.ToString());
        }
    }
}
