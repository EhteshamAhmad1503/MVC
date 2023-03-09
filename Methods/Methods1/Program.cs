using System;

namespace Methods1
{
    class Program
    {
        static void Main()
        {

            Program.EvenNumbers(30);
            Program p = new Program();
            int sum = p.add(40, 50);
            Console.WriteLine("sum is = {0}", sum);
                
        }
        public int add(int a,int b)
        {
            return a + b;
        }
        public static void EvenNumbers(int target)
        {
            int Start = 0;
            while (Start <= target)
            { 
                Console.WriteLine(Start);
                Start = Start +2;
            }
        }
    }
}
