using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EventHandlers.AzureServiceBus
{
    public class OrderServiceBusPublisher
    {
        private readonly string _connectionString;
        private readonly string _queueName;

        public OrderServiceBusPublisher(string connectionString, string queueName)
        {
            _connectionString = connectionString;
            _queueName = queueName;
        }

        public async Task PublishOrderAsync(int orderId, decimal amount)
        {
            var client = new ServiceBusClient(_connectionString);
            var sender = client.CreateSender(_queueName);

            var messageBody = new OrderCreatedMessage
            {
                OrderId = orderId,
                Amount = amount,
                CreatedOn = DateTime.UtcNow
            };

            var json = JsonSerializer.Serialize(messageBody);
            var message = new ServiceBusMessage(json);

            await sender.SendMessageAsync(message);

            Console.WriteLine($"Order message for OrderId {orderId} sent to Service Bus queue {_queueName}.");
        }

    }
}
