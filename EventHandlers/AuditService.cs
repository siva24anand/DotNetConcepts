using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers
{
    public class AuditService
    {
        public void LogOrder(object sender, OrderPlacedEventArgs e)
        {
            Console.WriteLine($"AuditService: Logging order placement. Order Id: {e.OrderId}, Date: {e.OrderDate}");
        }
    }
}
