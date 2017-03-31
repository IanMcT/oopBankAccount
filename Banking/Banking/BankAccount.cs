using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class BankAccount
    {
        public BankAccount()
        {
            balance = 0;
        }

        private Decimal balance;

        public void Deposit(Decimal amount)
        {
            if (amount > 0) 
            {
                balance = balance + amount;
            }
        }

        public void Deposit(Double amount)
        {
            Deposit((Decimal)amount);
        }

        public void Withdraw(Decimal amount)
        {
            if (amount <= balance) 
            {
                balance = balance - amount;
            }
        }

        public String showBalance()
        {
            return balance.ToString();
        }

        public override string ToString()
        {
            return "This is a bank account with a balance of " + balance.ToString("$#.00");
        }
    }
}
