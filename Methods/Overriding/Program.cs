using System;

namespace Overriding
{
   public  class Program
    {
        public class BaseClass
        {
            public virtual void Print()
            {
                Console.WriteLine("I  am a BaseClass Print Method");
            }
        }
        public class DriverClass:BaseClass
        {
            public override void Print()
            {
                Console.WriteLine("I am a DriveClass Print Method");
            }
        }

        static void Main(string[] args)
        {
            BaseClass B = new DriverClass();
            B.Print();
        }
    }
}
