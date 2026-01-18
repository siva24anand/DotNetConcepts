using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers
{
    public class EmailService
    {
        public void SendEmail(object sender, OrderPlacedEventArgs e)
        {
            Console.WriteLine($"EmailService: Sending email notification. Order Id: {e.OrderId}, Amount: {e.Amount}");
        }
    }
}
