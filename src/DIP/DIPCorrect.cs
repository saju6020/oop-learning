using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPCorrect
{
    // Abstraction
    public interface INotifier
    {
        void Send(string message);
    }

    // Low-Level Module (Email implementation)
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }

    // Low-Level Module (SMS implementation)
    public class SmsNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending SMS: " + message);
        }
    }

    // High-Level Module (Depends on abstraction)
    public class NotificationService
    {
        private INotifier notifier;  // Depends on abstraction

        public NotificationService(INotifier notifier)
        {
            this.notifier = notifier;  // Inject any implementation of INotifier
        }

        public void SendNotification(string message)
        {
            notifier.Send(message);  // Doesn't care if it's Email, SMS, etc.
        }
    }

}
