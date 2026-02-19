using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers.AzureServiceBus
{
    public class MainAzureSb
    {
        public static void Run()
        {
            var connectionString = "YourAzureServiceBusConnectionString";
            var queueName = "orders-queue";

            var publisher = new OrderServiceBusPublisher(connectionString, queueName);

            publisher.PublishOrderAsync(12345, 250.75m).GetAwaiter().GetResult();
        }
    }
}
