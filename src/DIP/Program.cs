// See https://aka.ms/new-console-template for more information
using DIPCorrect;

Console.WriteLine("Hello, World!");
INotifier emailNotifier = new EmailNotifier();
INotifier smsNotifier = new SmsNotifier();

NotificationService emailService = new NotificationService(emailNotifier);
emailService.SendNotification("Email message");

NotificationService smsService = new NotificationService(smsNotifier);
smsService.SendNotification("SMS message");