using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class BankAccount
    {
        private string CustomerName { get; set; }
        private int AccountNumber { get; set; }
        protected double Balance { get; set; }

        private int AccountCounter { get; set; }

        public BankAccount(string customerName, int accountNumber, double balance)
        {
            CustomerName = customerName;
            AccountNumber = accountNumber;
            Balance = balance;
            AccountCounter++;
        }

        public BankAccount(string customerName, double balance)
        {
            CustomerName = customerName;
            Balance = balance;
            AccountNumber = 100000 + AccountCounter;
            AccountCounter++;
        }

        public BankAccount(string customerName)
        {
            CustomerName = customerName;
            Balance = 0;
            AccountNumber = 100000 + AccountCounter;
            AccountCounter++;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
            Balance -= amount;
        }
    }
}
