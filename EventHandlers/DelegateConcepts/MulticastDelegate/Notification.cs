using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers.DelegateConcepts.MulticastDelegate
{
    public delegate void Notify(string message);
    public class Notification
    {
        public void Email(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }

        public void SMS(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }


    }
}
