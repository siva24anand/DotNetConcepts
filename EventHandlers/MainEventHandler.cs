using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers
{
    public class MainEventHandler
    {
        public static void Run()
        {
            var orderService = new OrderService();
            var emailService = new EmailService();
            var auditService = new AuditService();

            orderService.OrderPlaced += emailService.SendEmail;
            orderService.OrderPlaced += auditService.LogOrder;

            orderService.PlaceOrder(101, 2500.45m);
        }
    }
}
