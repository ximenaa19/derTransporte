using System;
using derTransporte.src.modules.creditWallet.Infrastructure.entity;

namespace derTransporte.src.modules.payments.Infrastructure.entity;

public class PaymentEntity
{
    public Guid Id { get; set; }
        public string ExternalReference { get; set; } = string.Empty;  // VARCHAR
        public decimal AmountMoney { get; set; }        // DECIMAL
        public DateTime CreatedAt { get; set; }         // TIMESTAMP
        public Guid WalletId { get; set; }              // FK → credit_wallet
        public Guid PaymentProviderId { get; set; }     // FK → payment_providers
        public Guid StatusId { get; set; }              // FK → payment_statuses
 
        // Navigation properties
        public CreditWalletEntity? Wallet { get; set; }
        //public PaymentProviderEntity PaymentProvider { get; set; }
        //public PaymentStatusEntity Status { get; set; }

}
