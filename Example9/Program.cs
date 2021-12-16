using System;

namespace Example9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fahrenhait derecesini gir");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("celcius derecesini gir");
            double celsius = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
            Console.ReadLine();
        }
    }
}
