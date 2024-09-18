// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");

//BankAccount bankAccount = new BankAccount("123456", "John Doe");
//bankAccount.Deposit(500);
//bankAccount.Withdraw(100);
//bankAccount.ShowAccountDetails();

//Console.WriteLine();

// Creating a SavingsAccount object
SavingsAccount savingsAccount = new SavingsAccount("789012", "Jane Doe", 0.05m); // 5% interest
savingsAccount.Deposit(1000);
savingsAccount.Withdraw(200);
savingsAccount.ShowAccountDetails();

Console.WriteLine();

// Apply interest to the savings account
savingsAccount.ApplyInterest();
savingsAccount.ShowAccountDetails();
