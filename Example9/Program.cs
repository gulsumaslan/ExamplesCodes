using System;

namespace Example9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter degrees fahrenhait");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter celcius degree");
            double celsius = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
            Console.ReadLine();
        }
    }
}
