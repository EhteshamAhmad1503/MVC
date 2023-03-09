using System;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("One" + " ");
                try
                {
                    Console.Write("Two" + " ");
                    goto exit;
                }
                finally
                {
                    Console.Write("Three" + " ");

                }
            }
            finally
            {
                Console.Write("Four" + " ");
            }
            exit:
            Console.Write("Good luck");
        }
    }
}
