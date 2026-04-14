using System;

namespace derTransporte.src.modules.paymentStatus.Infrastructure.entity;

public class PaymentStatusEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; }  = string.Empty;                // VARCHAR(100)

}
