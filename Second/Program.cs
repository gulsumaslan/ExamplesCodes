using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayiyi girinz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi giriniz");
            int m = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                if (i==m || i%m==0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
