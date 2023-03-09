using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] EM = new Employee[4];
            EM[0] = new Employee();
            EM[1] = new PartTimeEmployee();
            EM[2] = new FullTimeEmployee();

            EM[3] = new Temporary();
            foreach(Employee e in EM)
            {
                e.PrintFullName();
            }
        }

        public class Employee
        {
           public String FirstName = "FN";
           public  String LastName = "LN";

            public virtual void PrintFullName()
            {
                Console.WriteLine(FirstName+" "+LastName);
            }
          }
        public class PartTimeEmployee:Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName+ " - Part Time");
            }
        }
        public class FullTimeEmployee:Employee
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName+ " - Full Time");
            }
        }
        public class Temporary:Employee
        {
            public  override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName+ " - Temporary");
            }
        }
    }
}
