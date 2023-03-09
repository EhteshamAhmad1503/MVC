using System;

namespace ReadWrite
{
    class Program
    {
        private int _id;
        private string _Name;
        private int _PassMarks=35;

        public int passMarks
        {
            get
            {
                return this._PassMarks;
            }
        }
        public string name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Student is null or empty ");
                }
                 this._Name = value;
            }
            get
            {
                return this._Name;

            }
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id can not be negative value");
                }
                this._id= value;
            }
            get
            {
                return this._id;
            }
        }
             
        static void Main(string[] args)
        {

            Program P = new Program();
            P.Id = 10;
            P._Name = "Ehtesham Ahmad";
            Console.WriteLine("Student id= {0}",P.Id);
            Console.WriteLine("Student Name= {0}",P.name);
            Console.WriteLine("Student PassMarks= {0}",P.passMarks);


        }
    }
}
