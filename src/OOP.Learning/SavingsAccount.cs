using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Learning
{
    public class SavingsAccount : BankAccount
    {
        private const decimal InterestRate = 0.03m; // 3% annual interest rate

        public SavingsAccount(string accountNumber, string accountHolder, decimal initialDeposit)
            : base(accountNumber, accountHolder, initialDeposit)
        {
        }

        // Override to provide interest calculation logic for savings account
        public override void CalculateInterestOrOverdraft()
        {
            decimal interest = Balance * InterestRate;
            Balance += interest;
            Console.WriteLine($"Interest of {interest} applied. New balance: {Balance}");
        }
    }
}
