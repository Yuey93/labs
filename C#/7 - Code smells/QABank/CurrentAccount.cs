using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class CurrentAccount : Account
    {
        private double overdraftLimit;
        private List<Payee> directDebits = new List<Payee>();
        private List<Payee> standingOrders = new List<Payee>();

        public bool IsOverDrawn()
        {
            return balance < 0;
        }
        public void SetOverdraftLimit(double overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public void ProcessDirectDebits()
        {
            foreach (Payee payee in directDebits)
            {
                balance -= payee.amount;
            }
        }
        public void ProcessStandingOrders()
        {
            foreach (Payee payee in standingOrders)
            {
                balance -= payee.amount;
            }
        }
    }
}
