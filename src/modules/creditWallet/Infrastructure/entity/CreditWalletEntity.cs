using System;
using derTransporte.src.modules.creditTransactions.Infrastructure.entity;
using derTransporte.src.modules.payments.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;
using derTransporte.src.modules.transportCompanies.Infrastructure.entity;

namespace derTransporte.src.modules.creditWallet.Infrastructure.entity;

public class CreditWalletEntity
{
    public Guid Id { get; set; }
        public decimal Balance { get; set; }             // DECIMAL
        public DateTime LastUpdate { get; set; }         // TIMESTAMP
        public Guid PersonId { get; set; }               // FK → persons
        public Guid CompanyId { get; set; }              // FK → transport_companies
 
        // Navigation properties
        public PersonEntity? Person { get; set; }
        public transportCompanyEntity? Company { get; set; }
 
        // Hijos
        public ICollection<CreditTransactionEntity> Transactions { get; set; }= new List<CreditTransactionEntity>();
        public ICollection<PaymentEntity> Payments { get; set; }= new List<PaymentEntity>();

}
