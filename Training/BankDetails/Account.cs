using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails
{
   
   public class Account
    {
        public const double defaultBalance = 0;
        private double _amount;
        public double balance;
        /// <summary>
        /// 
        /// </summary>
        public double Balance
        {
            get { return defaultBalance; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Please enter an amount greater than 0");
                }
                else
                {
                    _amount = value;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double DoDeposit()
        {
            balance += _amount;
            return balance;
        }

        public double doWithdrawl()
        {
            balance -= _amount;

            if (balance < 0)
            {
                throw new ArgumentException("Withdrawing " + _amount.ToString("C") + " would leave you overdrawn!");
            }
            return balance;
        }
       
       
    }
}
