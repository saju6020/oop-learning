using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; private set; }

        public SavingsAccount(string accountNumber, string accountHolder, decimal interestRate)
            : base(accountNumber, accountHolder)
        {
            InterestRate = interestRate;
        }

        // Override the Withdraw method for savings account behavior
        public override void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from {AccountHolder}'s savings account. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Cannot overdraw a savings account. Withdrawal denied.");
            }
        }

        public void ApplyInterest()
        {
            decimal interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Applied interest of {interest:C} to {AccountHolder}'s savings account. New Balance: {Balance:C}");
        }
    }
}
