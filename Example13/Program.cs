using System;

namespace Example13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("yükseklik giriniz");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("taban uzunluğu giriniz");
            int t= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" üçgenin alanı:"+(h+t)/2);

        }
    }
}
