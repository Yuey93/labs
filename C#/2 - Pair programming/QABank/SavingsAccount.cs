using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    internal class SavingsAccount : BankAccount
    {
        private double InterestRate { get; set; }

        public SavingsAccount(string customerName, int accountNumber, double balance, double interestRate) : base(customerName, accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public SavingsAccount(string customerName, double balance, double interestRate) : base(customerName, balance)
        {
            InterestRate = interestRate;
        }

        public SavingsAccount(string customerName, double interestRate) : base(customerName)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            Balance += Balance * InterestRate;
        }
    }
}
