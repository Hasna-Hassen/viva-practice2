using System;
using System.Collections.Generic;
using System.Text;

namespace viva_practice2
{
    internal class SavingsAccount: BankAccount
    {
        public SavingsAccount(int accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

        public override double CalculateInterest()
        {
            return Balance * 0.05; // 5% interest
        }
    }
}
