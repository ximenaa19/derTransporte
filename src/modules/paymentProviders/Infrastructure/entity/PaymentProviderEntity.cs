using System;

namespace derTransporte.src.modules.paymentProviders.Infrastructure.entity;

public class PaymentProviderEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;                // VARCHAR(100)

}
