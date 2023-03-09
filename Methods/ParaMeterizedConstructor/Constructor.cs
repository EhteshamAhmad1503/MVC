using System;

namespace ParaMeterizedConstructor
{
    class Constructor
    {
        public int id;
        public String Name;
        public float Salary;
        public Constructor(int i,String s,float f)
        {
             id = i;
             Name = s;
            Salary = f;
        }
        public void display()
        {

            Console.WriteLine(id+ " "+Name+ " "+Salary);
        }
        static void Main(string[] args)
        {
            Constructor c1 = new Constructor(1,"Ehtesham",50000.6f);
            Constructor c2 = new Constructor(2,"Ajay",45000.5f);
            c1.display();
            c2.display();
        }   
    }
}
