using System;

namespace NestedIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num < 0 || Num > 100)
            {
                Console.WriteLine("Wrong Number");
            }
            else if (Num >= 0 && Num < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (Num >= 50 && Num < 60)
            {
                Console.WriteLine("Grade D");
            }
            else if (Num >= 60 && Num < 70)
            {
                Console.WriteLine("Grade C");
            }
            else if (Num >= 70 && Num < 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (Num >= 80 && Num < 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (Num >= 90 && Num <= 100)
            {
                Console.WriteLine("Grade A++");
            }
        }
    }
}
