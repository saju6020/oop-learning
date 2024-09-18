// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

BankAccount account = new BankAccount("123456", "John Doe");

account.Deposit(500); // Calls the Deposit(decimal)
account.Deposit("100"); // Calls the Deposit(string)
account.Deposit("invalid"); // Invalid string input

account.ShowAccountDetails();
