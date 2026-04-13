using System;
using derTransporte.src.modules.creditWallet.Infrastructure.entity;

namespace derTransporte.src.modules.creditTransactions.Infrastructure.entity;

public class CreditTransactionEntity
{
    public Guid Id { get; set; }
        public decimal Amount { get; set; }              // DECIMAL(10,2)
        public decimal BalanceAfter { get; set; }        // DECIMAL(10,2)
        public Guid? ReferenceId { get; set; }           // CHAR(36) - nullable
        public string Description { get; set; } =string.Empty;         // TEXT
        public DateTime CreatedAt { get; set; }          // DATETIME
        public Guid WalletId { get; set; }               // FK → credit_wallet
        public Guid TransactionTypeId { get; set; }      // FK → transaction_types
 
        public CreditWalletEntity? Wallet { get; set; }
        //public TransactionTypeEntity TransactionType { get; set; }

}
