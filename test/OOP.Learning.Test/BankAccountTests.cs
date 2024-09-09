using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Learning.Test
{
    public class BankAccountTests
    {
        // A derived class to test the abstract BankAccount class
        public class TestBankAccount : BankAccount
        {
            public TestBankAccount(string accountNumber, string accountHolder, decimal initialDeposit)
                : base(accountNumber, accountHolder, initialDeposit)
            {
            }

            // Implement the abstract method with test behavior
            public override void CalculateInterestOrOverdraft()
            {
                // Just a simple implementation for testing purposes
                Balance += 10;
            }
        }

        [Fact]
        public void Deposit_ShouldIncreaseBalance()
        {
            // Arrange
            var account = new TestBankAccount("12345", "John Doe", 1000m);

            // Act
            account.Deposit(200m);

            // Assert
            Assert.Equal(1200m, account.Balance);
        }

        [Fact]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientFunds()
        {
            // Arrange
            var account = new TestBankAccount("12345", "John Doe", 1000m);

            // Act
            account.Withdraw(500m);

            // Assert
            Assert.Equal(500m, account.Balance);
        }

        [Fact]
        public void Withdraw_ShouldNotChangeBalance_WhenInsufficientFunds()
        {
            // Arrange
            var account = new TestBankAccount("12345", "John Doe", 1000m);

            // Act
            account.Withdraw(1500m);

            // Assert
            Assert.Equal(1000m, account.Balance);
        }

        [Fact]
        public void CalculateInterestOrOverdraft_ShouldIncreaseBalance()
        {
            // Arrange
            var account = new TestBankAccount("12345", "John Doe", 1000m);

            // Act
            account.CalculateInterestOrOverdraft();

            // Assert
            Assert.Equal(1010m, account.Balance);
        }

        [Fact]
        public void Constructor_ShouldSetAccountDetailsCorrectly()
        {
            // Arrange & Act
            var account = new TestBankAccount("12345", "John Doe", 1000m);

            // Assert
            Assert.Equal("12345", account.AccountNumber);
            Assert.Equal("John Doe", account.AccountHolder);
            Assert.Equal(1000m, account.Balance);
        }
    }
}
