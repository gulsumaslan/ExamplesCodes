using System;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a sentence");
            string sentence = Console.ReadLine();
            //string letters = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"+ "abcçdefgğhiıjklmnoöprsştuüvyz";
            int character = 0;

            string[] words = cümle.Split(' ');
            char[] ch = sentence.ToCharArray();
            Console.WriteLine("Word Count :" + words.Length);
            
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            
            foreach (var letter in ch)
            {
                if (char.IsLetter(letter))
                {
                    character++;
                }
            }
            Console.WriteLine("letter numbers:" +character);
        }
    }
}
