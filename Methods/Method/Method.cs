using System;

namespace Method
{
    class Method
    {
       public int id;
       public  String Name;
        public void insert(int i,String n)
        {
            id = i;
            Name=n;
        }
        public void display()
        {
            Console.WriteLine(id + " " + Name);
        }
            static void Main(string[] args)
        {
            Method p1 = new Method();
            Method p2 = new Method();
            p1.insert(101,"Ehtesham");
            p2.insert(102,"Ehtesham Ahmad");
            p1.display ();
            p2.display();
           
               

        }
    }
}

