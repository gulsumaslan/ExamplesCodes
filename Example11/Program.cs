using System;

namespace Example11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir ürün alış fiyatını giriniz");
            double alis = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("bir ürün vergi fiyatını giriniz");
            double vergi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("bir ürün kar fiyatını giriniz");
            double kar = Convert.ToDouble(Console.ReadLine());



            double satis = alis + vergi * 0.5 + kar * 1.8;

            Console.WriteLine(satis);
            //Console.WriteLine("bir ürün alış fiyatını giriniz");
            //double satis = Convert.ToDouble(Console.ReadLine());

        }
    }
}
