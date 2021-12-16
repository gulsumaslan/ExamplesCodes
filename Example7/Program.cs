using System;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("birinci sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("üçüncü sayıyı giriniz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dördüncü sayıyı giriniz");
            int sayi4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("beşincisayıyı giriniz");
            int sayi5 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;
            double ortalama = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5;

            Console.WriteLine("toplam:"+toplam);
            Console.WriteLine("Ortalama:"+ortalama);


        }
    }
}
