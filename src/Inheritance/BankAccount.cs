using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; protected set; }


        //public BankAccount()
        //{
        //    Console.WriteLine("Inside default constructor");
        //}
        public BankAccount(string accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = 0; // Default balance is 0 when an account is created
        }

        // Virtual method to allow overriding in derived classes
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into {AccountHolder}'s account. New Balance: {Balance:C}");
        }

        // Virtual method to allow overriding in derived classes
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

        // A method that can be shared across all types of accounts
        public void ShowAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Account Holder: {AccountHolder}, Balance: {Balance:C}");
        }
    }
}
