using System;

namespace MainMethod
{
    class Program
    {
        public int id;
        public String Name;
        public float salary;

        public void Insert(int i,String n,float f)
        {
            id = i;
            Name = n;
            salary = f;
            
        }
        public void display()
        {
            Console.WriteLine(id+ " " +Name+ " " +salary);
        }

        static void Main(string[] args)
        {

            Program p1 = new Program();
            Program p2 = new Program();
            p1.Insert(101,"Ehtesham",60000.5f);
            p2.Insert(102,"Garv Sharma",70000.5f);
            p1.display();
            p2.display();
                      
        }
    }
}
