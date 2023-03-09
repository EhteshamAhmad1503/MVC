using System;

namespace Constructor
{
    class Constuct
    {
        public Constuct()
        {
            Console.WriteLine("Welcome to Constructor");
        }
        static void Main(string[] args)
        {
            Constuct c1 = new Constuct();
            Constuct c2 = new Constuct();
        }
    }
}
