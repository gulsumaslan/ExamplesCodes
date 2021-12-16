using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kelime giriniz");
            string n = Console.ReadLine();

            Console.WriteLine("kelimenin sondan başa doğru yazımı");

            for (int i = n.Length-1; i >= 0; --i)
            {
                Console.Write(n[i]);
            }
        }
    }
}
