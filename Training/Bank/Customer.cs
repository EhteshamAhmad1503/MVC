using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   public class Customer
    {

        public Customer()
        {
            Console.WriteLine("Enter your Name...");
            this.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter your Mobile number...");
            this.MobileNumber = Convert.ToInt64(  Console.ReadLine());
            Console.WriteLine("Enter your Address...");
            this.Address = Console.ReadLine();
            Console.WriteLine("Enter your Email Id.....");
            this.Email = Console.ReadLine();
            Console.WriteLine("Enter your Pan Number...");
            this.PanNumber = Console.ReadLine();
            this.CustomerId = CustomerId + 1;
               
        }
        public String CustomerName;
        public int CustomerId=3000;
        public long MobileNumber;
        public String Address;
        public string Email;
        public string PanNumber;

    }

   public  class Account:Customer 
    {

        private long AccountNumber = 51102200001;
        private string AccountType=string.Empty;
        private double AccountBalance=0.0;
        public int TransactionId = 10001;
        public DateTime TransactionDate;
        public int TransactionAmount;
        public int AccountId;

        public List<string> transactionsList = new List<string>();

        public Account(long count):base()
        {
            this.AccountNumber = AccountNumber + count;
            count = count + 1;
        }
        
      public long getAccNum()
        {
            return this.AccountNumber;
        }

        public double getAccBal()
        {
            return this.AccountBalance;
        }

        public void setAccBal(double cash)
        {
             this.AccountBalance= AccountBalance+cash;
        }

        public void withdraw(double cash)
        {
            if (cash < 0)
            {
                Console.WriteLine("Enter valid amount");
            }
            else if (cash > getAccBal())
            {
                Console.WriteLine("Enter below available amount");
            }
            else if (getAccBal() > 0)
            {
                double n = getAccBal();
                setAccBal(n-cash);
                TransactionId = TransactionId + 1;
                DateTime now = DateTime.Now;
                TransactionDate = now;
                transactionsList.Add("TransID: "+Convert.ToString(TransactionId)+"  " + Convert.ToString(TransactionDate) + Convert.ToString(cash) + "  withdrawed");
                Console.WriteLine("Collect Your Cash Here....");
            }

        }

        public void deposit(double amount)
        {
            if (amount > 0)
            {
                double n = getAccBal();
                setAccBal((amount + n));
                TransactionId = TransactionId + 1;
                DateTime now = DateTime.Now;
                TransactionDate = now;
                transactionsList.Add("TransID: "+Convert.ToString(TransactionId)+"  " + Convert.ToString(TransactionDate) + Convert.ToString(amount) + "  Deposited");
                Console.WriteLine("Deposited sucessfully....");

            }
        }

        public void getAccountinfo()
        {
            Console.WriteLine("Account Holder Name :"+base.CustomerName);
            Console.WriteLine("Account Number :"+this.AccountNumber);
            Console.WriteLine("CustomerID :" + base.CustomerId);
            Console.WriteLine("Mobile Number :" + base.MobileNumber);
            Console.WriteLine("Address :" + base.Address);
            Console.WriteLine("Email :" + base.Email);
            Console.WriteLine("Pan Number :" + base.PanNumber);
        }
     }

   public  class CreateAccount
    {
      
      public Account cust;
        public CreateAccount(long count)
        {
           //cust= createAccount(count);
        }

        public Account createAccount(long count)
        {
           
             cust = new Account(count);
                     

            return cust ;
        }

     }
}
