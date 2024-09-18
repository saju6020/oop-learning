using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolymorphism
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = 0; // Default balance is 0
        }

        // Method overloading: deposit with decimal amount
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into {AccountHolder}'s account. New Balance: {Balance:C}");
        }

        // Overloaded method: deposit with string amount
        public void Deposit(string amount)
        {
            decimal value;
            if (decimal.TryParse(amount, out value))
            {
                Deposit(value); // Calls the decimal version of Deposit
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        public virtual void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from {AccountHolder}'s account. New Balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        public void ShowAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Account Holder: {AccountHolder}, Balance: {Balance:C}");
        }
    }
}
