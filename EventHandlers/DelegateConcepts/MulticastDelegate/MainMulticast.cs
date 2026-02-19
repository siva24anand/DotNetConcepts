using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers.DelegateConcepts.MulticastDelegate
{
    public class MainMulticast
    {
        public static void Run()
        {
            var service = new Notification();

            Notify notify = service.Email;
            notify += service.SMS;

            notify("Hello! This is a multicast delegate example.");
        }
    }
}
