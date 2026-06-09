using System;
using System.Collections.Generic;
using System.Text;

namespace viva_practice2
{
    public abstract class BankAccount
    {
        private int accountNumber;
        private string holderName;
        private double balance;

        protected BankAccount(int accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string HolderName { get => holderName; set => holderName = value; }
        public double Balance { get => balance; set => balance = value; }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public abstract double CalculateInterest();
    }
}
