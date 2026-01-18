using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers
{
    public class OrderService
    {
        public event EventHandler<OrderPlacedEventArgs> OrderPlaced;

        public void PlaceOrder(int orderId, decimal amount)
        {
            Console.WriteLine($"Order { orderId } placed.");

            var eventData = new OrderPlacedEventArgs
            {
                OrderId = orderId,
                Amount = amount,
                OrderDate = DateTime.Now
            };

            OrderPlaced?.Invoke(this, eventData);
        }
    }
}
