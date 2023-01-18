using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your visa note");
            int visa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your final grade");
            int final = Convert.ToInt32(Console.ReadLine());

            double average = visa * 0.40 + final * 0.60;

            if (visa>=50 && final>50)
            {
                Console.WriteLine(average);
                Console.WriteLine( "you passed the exam");
            }
            else
            {
                Console.WriteLine(average);
                Console.WriteLine("you stayed");
            }

        }
    }
}
