using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    internal class CurrentAccount : BankAccount
    {
        private double OverdraftLimit { get; set; }

        public CurrentAccount(string customerName, int accountNumber, double balance, double overdraftLimit) : base(customerName, accountNumber, balance)
        {
            OverdraftLimit = overdraftLimit;
            Balance += overdraftLimit;
        }

        public CurrentAccount(string customerName, double balance, double overdraftLimit) : base(customerName, balance)
        {
            OverdraftLimit = overdraftLimit;
            Balance += overdraftLimit;
        }

        public CurrentAccount(string customerName, double overdraftLimit) : base(customerName)
        {
            OverdraftLimit = overdraftLimit;
            Balance += overdraftLimit;
        }

    }
}
