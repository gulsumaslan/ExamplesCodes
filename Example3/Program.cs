using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi>0)
            {
                Console.WriteLine("sayı pozitiftir");

            }
            else if (sayi<0)
            {
                Console.WriteLine("sayi negatiftir");
            }
            else
            {
                Console.WriteLine("sayı 0 dır");
            }
        }
    }
}
