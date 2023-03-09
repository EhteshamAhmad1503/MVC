using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int accountTypeId = 0;
            long amount = 10000, deposit, withdraw;
            long choice, Account = 0, x = 10;
            Console.WriteLine("Enter Your Account Number");
            Account = long.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Account Type");
            Console.WriteLine("1. Saving");
            Console.WriteLine("2. Current");



            string accountType = Console.ReadLine();
            accountTypeId = Convert.ToInt32(accountType);
            string yesNo = string.Empty;

            while (true)
            {
                Console.WriteLine("WELCOME TO  CANARA BANK\n");
                Console.WriteLine("1. Current Balance");
                Console.WriteLine("2. Withdraw ");
                Console.WriteLine("3. Deposit ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("YOUR CURRENT BALANCE IS Rs : {0} \n", amount);
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
                            Console.WriteLine("\nPLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        break;



                }
            }
        }
    }
}
