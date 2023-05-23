using mass_transit_worker.Contracts;
using MassTransit;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace mass_transit_worker.Consumers
{
    public class OrderConsumer : IConsumer<OrderRecord>
    {
        private readonly ILogger<OrderConsumer> logger;

        public OrderConsumer(ILogger<OrderConsumer> log)
        {
            logger = log;
        }

        public Task Consume(ConsumeContext<OrderRecord> context)
        {
            logger.LogInformation("Order Received {orderName} {orderDate}", context.Message.Name, context.Message.Received);
            return Task.CompletedTask;
        }
    }
}
