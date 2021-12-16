using System;

namespace ExamplesCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <n; i++)
            {
               // Console.Write("{0}. sayıyı girin : ", i);
               // int sayi= Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                   
                }
            }
        }
    }
    }

