using System;

namespace Nested_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int J = 1;
                while (J<=5)
                {
                    Console.WriteLine(i+" "+J);
                    J++;
                }
                i++;
            }
        }
    }
}
