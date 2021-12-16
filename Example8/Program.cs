using System;

namespace Example8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz ");
            int N = Convert.ToInt32(Console.ReadLine());

            int faktoriyel = 1;
            for (int i = 1; i <= N; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(faktoriyel);
        }
    }
}
