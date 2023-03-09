using System;

namespace ParaMeterArrays
{
    class Program
    {
        static void Main()
        {
            int[] Numbers = new int[5];
            Numbers[0]=101;
            Numbers[1]=102;
            Numbers[2]=103;
            Numbers[3]=104;
            Numbers[4]=105;

            ParamsMethod(Numbers);
            
        }
        public static void ParamsMethod(params int [] Numbers)
        {
            Console.WriteLine("There are Five {0} Elements",Numbers.Length);
            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
