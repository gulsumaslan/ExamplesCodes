using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize notunuzu giriniz");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("final notunuzu giriniz");
            int final = Convert.ToInt32(Console.ReadLine());

            double ortalama = vize * 0.40 + final * 0.60;

            if (vize>=50 && final>50)
            {
                Console.WriteLine(ortalama);
                Console.WriteLine( "sınavı geçtiniz");
            }
            else
            {
                Console.WriteLine(ortalama);
                Console.WriteLine("kaldınız");
            }

        }
    }
}
