using System;

namespace Example15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi>0)
            {
                Console.WriteLine("sayı pozitiftir"+sayi);
            }
            else
            {
                Console.WriteLine("sayi negatiftir"+sayi);
            }
        }
    }
}
