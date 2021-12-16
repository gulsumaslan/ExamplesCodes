using System;

namespace Example14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Akım değerini giriniz");
            int akim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Direnç değerini  giriniz");
            int direnc= Convert.ToInt32(Console.ReadLine());

            int Gerilim = akim * direnc;
            Console.WriteLine(Gerilim);
        }
    }
}
