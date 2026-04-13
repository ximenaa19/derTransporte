using System;
using derTransporte.src.modules.payments.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.subscriptions.Infrastructure.entity;

public class SubscriptionEntity
{
    public Guid Id { get; set; }
        public DateTime StartDate { get; set; }          // DATETIME
        public DateTime EndDate { get; set; }            // DATETIME
        public bool AutoRenew { get; set; }              // TINYINT(1)
        public Guid PersonId { get; set; }               // FK → persons
        public Guid SubscriptionTypeId { get; set; }     // FK → subscription_type
        public Guid StatusId { get; set; }               // FK → subscription_status
        public Guid PaymentId { get; set; }              // FK → payments
 
        public PersonEntity? Person { get; set; }
        //public SubscriptionTypeEntity? SubscriptionType { get; set; }
        //public SubscriptionStatusEntity? Status { get; set; }
        public PaymentEntity? Payment { get; set; }

}
