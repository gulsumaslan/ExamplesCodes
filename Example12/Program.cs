using System;

namespace Example12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter visa note");
            int visa= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter final grade");
            int final = Convert.ToInt32(Console.ReadLine());

            double ortalama = visa * 0.30 + final * 0.70;
            Console.WriteLine(average);

        }
    }
}
