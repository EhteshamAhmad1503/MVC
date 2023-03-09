using System;

namespace Struct
{
    public struct Customer
    {
        private int _id;
        private string _Name;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Customer(int i, string s)
            {
            this._id = i;
            this._Name =s;
                        
            }
        public void print()
        {
            Console.WriteLine("Student Id= {0}  Name={1}",Id,name);
           // Console.WriteLine("Student Name= {0}",name);
        }

        static void Main(string[] args)
        {
            Customer C = new Customer(101,"Ehtesham");
            C.print();
            
        }
    }
}
