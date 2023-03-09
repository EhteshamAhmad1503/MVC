using System;

namespace SetterGatter
{
    class Program
    {
        private int _id;
        private string _Name;
        private int _PassMarks=250;


        public int getPassMarks()
        {
            return (_PassMarks);
        }

        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name can not be  Null or Empty");
            }
            this._Name = name;
        }
        public string getName()
        {
            if (string.IsNullOrEmpty(this._Name))
            {
                return ("No Name");
            }
            else
            {
                return this._Name;
            }
        }

        public void setId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student can not Sapport Negative value");
            }
            this._id = Id;

        }
        public int getId()
        {
            return this._id;
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.setId(100);
            p.setName("Ehtesham Ahmad");
            Console.WriteLine("Student id={0}", p.getId());
            Console.WriteLine("Student Name={0}",p.getName());
            Console.WriteLine("Student PassMarks={0}",p.getPassMarks());


        }
     }
}

