using System;
using System.Collections.Generic;
using Bank;
    
namespace Access

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accountHoldersList = new List<Account>();
            long count = 0;
            Boolean exp = true;

            do
            {
                Console.WriteLine("What are you looking for....");
                Console.WriteLine("1 Create Account");
                Console.WriteLine("2 login to your Account");
                long choice = Convert.ToInt64(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Bank.CreateAccount a1 = new CreateAccount(count);
                        Account cust= a1.createAccount(count);
                        Console.WriteLine("Successfully created Account your AccNuM is:"+cust.getAccNum());
                        accountHoldersList. Add(cust);
                        count += 1;
                        break;

                    case 3:
                        foreach (Account a in accountHoldersList)
                        {

                            a.getAccountinfo();
                        }
                        break;

                    case 2:

                        Console.WriteLine("Enter your acc number....");
                        
                        string accountNumber = Console.ReadLine();
                        long accNum = 0;
                            if (!string.IsNullOrWhiteSpace(accountNumber))
                        {
                            accNum= Convert.ToInt64(accountNumber);
                        }
                        int isAccountFound = 0;
                        foreach (Account a in accountHoldersList)
                        {
                            
                            if (a.getAccNum() == accNum)
                            {
                                isAccountFound = 1;                                
                                exp = true;
                                while (exp)
                                {
                                    Console.WriteLine("1 Check balance");
                                    Console.WriteLine("2.Deposit Amount");
                                    Console.WriteLine("3.Withdraw Amount");
                                    Console.WriteLine("4.Transaction History");
                                    Console.WriteLine("5 Accont information");
                                    Console.WriteLine("6 Exit");

                                    int next = Convert.ToInt32(Console.ReadLine());
                                    switch (next)
                                    {
                                        case 1:
                                            Console.WriteLine(" Your Account balance is : " + a.getAccBal());

                                            break;
                                        case 2:
                                            Console.WriteLine("Enter Ammount to deposite");
                                            double ammount = Convert.ToDouble(Console.ReadLine());
                                             a.deposit(ammount);
                                            break;

                                        case 3:
                                            Console.WriteLine(" Enter how mouch ammount you want to withdraw");
                                            double withdraw = Convert.ToDouble(Console.ReadLine());
                                            a.withdraw(withdraw);

                                            break;

                                        case 4:
                                            Console.WriteLine("Transaction History is: ");
                                            foreach (string i in a.transactionsList)
                                            {
                                                Console.WriteLine(i);
                                            }
                                            break;
                                        case 5:
                                            Console.WriteLine("Account information is: ");
                                            a.getAccountinfo();
                                            break;

                                        case 6:
                                            exp = false;
                                            break;
                                    }
                                }
                               
                            }
                                              
                        }
                        if (isAccountFound == 0) 
                        {
                            Console.WriteLine("Not exist...");
                        }

                        break;
                }

            } while (true);
                          
            }
        }
    }
 