
using System;
using derTransporte.src.modules.documentCustomers.Infrastructure.entity;
using derTransporte.src.modules.loads.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.customers.Infrastructure.entity;

public class CustomerEntity
{
    public Guid Id { get; set; }
        public bool IsFrequent { get; set; }             // BOOLEAN
        public Guid PersonId { get; set; }               // FK → persons
 
        // Navigation properties
        public PersonEntity? Person { get; set; }
 
        // Hijos
        public ICollection<LoadEntity> Loads { get; set; }= new List<LoadEntity>();
        public ICollection<DocumentCustomerEntity> Documents { get; set; } = new List<DocumentCustomerEntity>();

}
