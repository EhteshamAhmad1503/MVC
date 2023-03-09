using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a%2==0)
            {
                Console.WriteLine("It is Even Number");
            }
        }
    }
}
