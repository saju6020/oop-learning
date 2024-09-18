using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; private set; }

        // Constructor calls base constructor and sets the interest rate
        //public SavingsAccount(string accountNumber, string accountHolder, decimal interestRate)// Calling the base class constructor
        //{
        //    InterestRate = interestRate;
        //}

        // Override the Withdraw method to enforce savings account withdrawal rules (no overdraft)
        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from {AccountHolder}'s savings account. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Cannot overdraw a savings account.");
            }
        }

        // New method specific to SavingsAccount to apply interest
        public void ApplyInterest()
        {
            decimal interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Applied interest of {interest:C} to {AccountHolder}'s savings account. New Balance: {Balance:C}");
        }
    }
}
