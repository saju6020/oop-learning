using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Learning
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public decimal Balance { get; protected set; }

        // Constructor to create the account
        public BankAccount(string accountNumber, string accountHolder, decimal initialDeposit)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialDeposit;
        }

        // Abstract method to implement specific account behavior
        public abstract void CalculateInterestOrOverdraft();

        // Method for depositing money (common for all accounts)
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount} deposited. New balance: {Balance}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

    }
}
