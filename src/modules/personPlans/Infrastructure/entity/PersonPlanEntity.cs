using System;
using derTransporte.src.modules.payments.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;
using derTransporte.src.modules.plans.Infrastructure.entity;

namespace derTransporte.src.modules.personPlans.Infrastructure.entity;

public class PersonPlanEntity
{
    public Guid Id { get; set; }
        public decimal CreditsGranted { get; set; }          // DECIMAL(10,2)
        public decimal UnitPriceAtPurchase { get; set; }     // DECIMAL(10,2)
        public DateTime PurchasedAt { get; set; }            // DATETIME
        public Guid PersonId { get; set; }                   // FK → persons
        public Guid PlanId { get; set; }                     // FK → plans
        public Guid PaymentId { get; set; }                  // FK → payments
 
        public PersonEntity? Person { get; set; }
        public PlanEntity? Plan { get; set; }
        public PaymentEntity? Payment { get; set; }

}
