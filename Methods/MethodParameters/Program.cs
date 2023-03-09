using System;

namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Numbers(ref i);
            Console.WriteLine(i);
        }
        public static void Numbers(ref int j)
        {
             j = 101;
        }
    }
}
