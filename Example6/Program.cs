using System;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir fiyat giriniz");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            double kdv = fiyat * 0.18;
            double toplam = fiyat +kdv;
            Console.WriteLine(toplam.ToString());
        }
    }
}
