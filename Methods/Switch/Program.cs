using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {


            double Result = 0;

            Console.WriteLine("Enter A Number");
            double Num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            double Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Operation");
            char Operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (Operation)
            {
                case '+':
                    Result = Num + Num1;
                    break;


                case '-':
                    Result = Num - Num1;
                    break;


                case '*':
                    Result = Num * Num1;
                    break;


                case '/':
                    Result = Num / Num1;
                    break;


                case '%':
                    Result = Num % Num1;
                    break;

                default: Console.WriteLine("Invalid");
                    break;
            }
            Console.WriteLine("Result = " + Result);
            
            Console.ReadLine();
        }
    }
}
