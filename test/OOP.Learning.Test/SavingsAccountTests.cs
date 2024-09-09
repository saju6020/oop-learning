using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Learning.Test
{
    public class SavingsAccountTests
    {
        [Fact]
        public void Deposit_ShouldIncreaseBalance()
        {
            // Arrange
            var account = new SavingsAccount("SA12345", "John Doe", 1000m);

            // Act
            account.Deposit(500m);

            // Assert
            Assert.Equal(1500m, account.Balance);
        }

        [Fact]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientFunds()
        {
            // Arrange
            var account = new SavingsAccount("SA12345", "John Doe", 1000m);

            // Act
            account.Withdraw(300m);

            // Assert
            Assert.Equal(700m, account.Balance);
        }

        [Fact]
        public void Withdraw_ShouldNotChangeBalance_WhenInsufficientFunds()
        {
            // Arrange
            var account = new SavingsAccount("SA12345", "John Doe", 1000m);

            // Act
            account.Withdraw(1500m);

            // Assert
            Assert.Equal(1000m, account.Balance);  // Withdrawal denied
        }

        [Fact]
        public void CalculateInterestOrOverdraft_ShouldIncreaseBalanceWithInterest()
        {
            // Arrange
            var account = new SavingsAccount("SA12345", "John Doe", 1000m);
            var expectedInterest = 1000m * 0.03m; // 3% interest on 1000

            // Act
            account.CalculateInterestOrOverdraft();

            // Assert
            Assert.Equal(1000m + expectedInterest, account.Balance);
        }

        [Fact]
        public void Constructor_ShouldInitializeAccountCorrectly()
        {
            // Arrange & Act
            var account = new SavingsAccount("SA12345", "John Doe", 1000m);

            // Assert
            Assert.Equal("SA12345", account.AccountNumber);
            Assert.Equal("John Doe", account.AccountHolder);
            Assert.Equal(1000m, account.Balance);
        }
    }
}
