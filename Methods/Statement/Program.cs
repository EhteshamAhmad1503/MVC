using System;

namespace Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("It is a even Number");
            }
            else
            {
                Console.WriteLine("It is a Odd Number");
            }
        }
    }
}
