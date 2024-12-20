using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class Account
    {
        // We would have getters/setters for these but left out to minimise the code
        private string firstname, lastname, address;
        private int accountNumber;
        protected double balance;
        private String accountType;

        public void WithDraw(double amount)
        {
            if (amount > balance && accountType == "deposit")
                return;
            balance -= amount;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
    }
}
