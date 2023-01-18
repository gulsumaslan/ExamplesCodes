using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word");
            string n = Console.ReadLine();

            Console.WriteLine("spelling of the word");

            for (int i = n.Length-1; i >= 0; --i)
            {
                Console.Write(n[i]);
            }
        }
    }
}
