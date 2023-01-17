using System;

namespace Example13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter height");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter floor length");
            int t= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" area of triangle:"+(h+t)/2);

        }
    }
}
