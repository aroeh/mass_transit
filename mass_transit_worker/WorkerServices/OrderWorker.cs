using mass_transit_worker.Contracts;
using MassTransit;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace mass_transit_worker.WorkerServices
{
    public class OrderWorker : BackgroundService
    {
        private readonly IBus _bus;

        public OrderWorker(IBus b)
        {
            _bus = b;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _bus.Publish(new OrderRecord { Status = "New", Name = "New Order", Received = DateTime.UtcNow}, stoppingToken);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
