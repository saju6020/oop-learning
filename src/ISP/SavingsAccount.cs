using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class SavingsAccount : IBankAccount, IInterestBearingAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into savings account. New Balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from savings account. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        public void ApplyInterest()
        {
            // Apply interest to the balance
            Console.WriteLine("Interest applied to savings account.");
        }
    }
}
