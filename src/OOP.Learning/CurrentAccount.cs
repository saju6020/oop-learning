using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Learning
{
    public class CurrentAccount : BankAccount
    {
        private const decimal OverdraftLimit = 500m;

        public CurrentAccount(string accountNumber, string accountHolder, decimal initialDeposit)
            : base(accountNumber, accountHolder, initialDeposit)
        {
        }

        // Override to handle overdraft logic for current account
        public override void CalculateInterestOrOverdraft()
        {
            if (Balance < 0 && Math.Abs(Balance) <= OverdraftLimit)
            {
                Console.WriteLine($"Account is overdrawn by {Math.Abs(Balance)} within the limit.");
            }
            else if (Balance < 0 && Math.Abs(Balance) > OverdraftLimit)
            {
                Console.WriteLine("Overdraft limit exceeded!");
            }
            else
            {
                Console.WriteLine("No overdraft applied. Balance is positive.");
            }
        }

        // Allow overdraft withdrawals
        public override void Withdraw(decimal amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn using overdraft. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded, withdrawal denied.");
            }
        }
    }
}
