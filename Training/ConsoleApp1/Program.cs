using System;
using System.Collections.Generic;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> History= new List<string>();
            int accountTypeId = 0;
            long amount = 10000, deposit, withdraw;
            long choice, Account = 0, x = 10;
            DateTime now = DateTime.Now;
            Console.WriteLine("Enter Your Account Number");
            Account = long.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Account Type");
            Console.WriteLine("1. Saving");
            Console.WriteLine("2. Current");
                                 
            string accountType = Console.ReadLine();
            accountTypeId = Convert.ToInt32(accountType);
           
            while (true)
            {
                Console.WriteLine("WELCOME TO  CANARA BANK\n");
                Console.WriteLine("1. Current Balance");
                Console.WriteLine("2. Withdraw ");
                Console.WriteLine("3. Deposit ");
                Console.WriteLine("4. Transaction History ");
               

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nYOUR CURRENT BALANCE IS Rs : {0} \n", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            History.Add(Convert.ToString(now) + " " + withdraw + " Withadrawed");
                            Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);

                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        History.Add(Convert.ToString( now)+" "+ deposit + " Deposited ");
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        break;

                    case 4:
                        foreach (string i in History)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                }
            }
        }
    }
}
