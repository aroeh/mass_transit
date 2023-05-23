using System;

namespace mass_transit_worker.Contracts
{
    public record OrderRecord
    {
        public string Id { get; init; }

        public string Status { get; init; }

        public string Name { get; init; }

        public DateTime Received { get; init; }
    }
}
