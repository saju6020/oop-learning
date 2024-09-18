// See https://aka.ms/new-console-template for more information
using ISP;

Console.WriteLine("Hello, World!");

IBankAccount savings = new SavingsAccount();
savings.Deposit(1000);
savings.Withdraw(200);
savings.ShowAccountDetails();
((SavingsAccount)savings).ApplyInterest();

IBankAccount current = new CurrentAccount();
current.Deposit(500);
current.Withdraw(800);  // Overdraft use
current.ShowAccountDetails();
