using System;

namespace Example12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vize notu giriniz");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("final notu giriniz");
            int final = Convert.ToInt32(Console.ReadLine());

            double ortalama = vize * 0.30 + final * 0.70;
            Console.WriteLine(ortalama);

        }
    }
}
