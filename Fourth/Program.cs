using System;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("bir cümle giriniz");
            string cümle = Console.ReadLine();
            //string harfler = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"+ "abcçdefgğhiıjklmnoöprsştuüvyz";
            int character = 0;

            string[] kelimeler = cümle.Split(' ');
            char[] ch = cümle.ToCharArray();
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);
            
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            
            foreach (var harf in ch)
            {
                if (char.IsLetter(harf))
                {
                    character++;
                }
            }
            Console.WriteLine("harf sayısı:" +character);
        }
    }
}
