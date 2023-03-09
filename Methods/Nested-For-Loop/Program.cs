using System;

namespace Nested_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
          for (int i = 5; i >=1; i--)
           {
                for (int j = 1; j <= 5; j++)
                {
                   Console.WriteLine(i+" "+j);
                   
                }
            }
        }
    }
}
