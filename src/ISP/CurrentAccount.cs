using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class CurrentAccount : IBankAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into current account. New Balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from current account. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }
    }
}
