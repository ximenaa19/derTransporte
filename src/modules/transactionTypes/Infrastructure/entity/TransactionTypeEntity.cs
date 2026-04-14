using System;

namespace derTransporte.src.modules.transactionTypes.Infrastructure.entity;

public class TransactionTypeEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;                // VARCHAR(100)
}
