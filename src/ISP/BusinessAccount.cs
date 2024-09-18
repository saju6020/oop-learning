using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class BusinessAccount : IBankAccount, IFeeChargingAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into business account. New Balance: {Balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from business account. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        public void CalculateFees()
        {
            // Calculate and deduct fees
            Console.WriteLine("Fees calculated for business account.");
        }
    }
}
