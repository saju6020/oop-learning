using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPBreak
{
    // Low-Level Module (Concrete implementation)
    public class EmailNotifier
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }

    // High-Level Module (Directly depends on the low-level module)
    public class NotificationService
    {
        private EmailNotifier emailNotifier;

        public NotificationService()
        {
            emailNotifier = new EmailNotifier();  // Direct dependency
        }

        public void Send(string message)
        {
            emailNotifier.SendEmail(message);  // Sends only email
        }
    }

}
