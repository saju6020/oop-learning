// See https://aka.ms/new-console-template for more information
using DynamicPolymorphism;

Console.WriteLine("Hello, World!");

// Base class reference pointing to derived class object
BankAccount account = new SavingsAccount("789012", "Jane Doe", 0.05m);

account.Deposit(1000);
account.Withdraw(200); // Calls the overridden method in SavingsAccount

// Dynamic polymorphism allows calling the correct method based on actual object type
account.ShowAccountDetails();

// To call ApplyInterest, we need to cast to SavingsAccount
((SavingsAccount)account).ApplyInterest();
account.ShowAccountDetails();
