using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkincii sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1>sayi1)
            {
                Console.WriteLine("Büyük olan sayi:" + sayi1);
            }
            else
            {
                Console.WriteLine("Büyük olan sayi:"+sayi2);
            }
        }
    }
}
