using System;

namespace Hidding
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "EHTESHAM";
            FTE.LasttName = "AHMAD";
            FTE.FullNameMethode();
         

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "AHAD";
            PTE.LasttName = "AMIR";
            //PTE.FullNameMethode();
            ((Employee)PTE).FullNameMethode();
        }
        public class Employee
        {
         public String FirstName;
         public String LasttName;

            public void FullNameMethode()
            {
                Console.WriteLine(FirstName+ " " +LasttName);
            }
        }
        public class FullTimeEmployee:Employee
        {
            public new  void FullNameMethode()
            {
                //base.FullNameMethode();

                Console.WriteLine(FirstName + " " + LasttName+ " Hidding");
            }
        }
        public class PartTimeEmployee : Employee
        {

        }
    }
}
