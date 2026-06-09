using System;
using System.Collections.Generic;
using System.Text;

namespace viva_practice2
{
    internal class CurrentAccount:BankAccount
    {
        public CurrentAccount(int accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

        public override double CalculateInterest()
        {
            return Balance * 0.01; // 1% interest for current accounts
        }
    }
}
