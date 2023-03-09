using System;

namespace Training
{
    public class Calculator

    {

        public Calculator()

        {

        }

        public int Add(int num1, int num2)

        {

            return num1 + num2;

        }
        public int sub(int num1, int num2)

        {

            return num1 - num2;

        }

        public int Multiply(int num1, int num2)

        {



            return num1 * num2;

        }

        public int Division(int num1, int num2)

        {


            return num1 / num2;

        }

    
            static void Main(string[] args)
             {
              Calculator cal = new Calculator();
              int sum = cal.Add(1000,5100);
              Console.WriteLine("Sum is={0}", sum);

              Calculator cal1 = new Calculator();
              int sub = cal.sub(66000, 4000);
              Console.WriteLine("Sub is={0}", sub);

              Calculator cal2 = new Calculator();
              int mul = cal.Multiply(2000, 1000);

              Console.WriteLine("Mul is={0}", mul);

               Calculator cal3 = new Calculator();
              int div = cal.Division(50000, 200);
              Console.WriteLine("Div is={0}", div);
        }

    }
}
