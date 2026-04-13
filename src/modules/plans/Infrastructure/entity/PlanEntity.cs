using System;
using derTransporte.src.modules.personPlans.Infrastructure.entity;

namespace derTransporte.src.modules.plans.Infrastructure.entity;

public class PlanEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; }  = string.Empty  ;            // VARCHAR
        public decimal CreditAmount { get; set; }       // DECIMAL
        public decimal Price { get; set; }              // DECIMAL
        public bool IsActive { get; set; }              // BOOLEAN
 
        // Hijos
        public ICollection<PersonPlanEntity> PersonPlans { get; set; }= new List<PersonPlanEntity>();

}
