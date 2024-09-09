using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a savings account
            BankAccount savings = new SavingsAccount("SA123", "John Doe", 1000);
            savings.Deposit(500);
            savings.Withdraw(300);
            savings.CalculateInterestOrOverdraft();

            Console.WriteLine();

            // Creating a current account
            BankAccount current = new CurrentAccount("CA456", "Jane Smith", 200);
            current.Deposit(300);
            current.Withdraw(600);  // Withdraw within overdraft limit
            current.Withdraw(200);  // Overdraft limit exceeded
           // current.Withdraw(400);
            current.CalculateInterestOrOverdraft();
        }
    }
}
