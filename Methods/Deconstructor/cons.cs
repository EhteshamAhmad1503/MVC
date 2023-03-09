using System;

namespace Deconstructor
{
    class cons
    {
        public String FirstName;
        public String LastName;

        public cons(String FirstName, String LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }
        ~cons()
        {
            Console.WriteLine("Thisis deconstructor");
        }
        public void display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        static void Main(string[] args)
        {
            cons c1 = new cons("Ehtesham", "Ahmad");
            cons c2 = new cons("Altaf", "Ahmad");
            c1.display();
            c2.display();

        }
    }
}

