using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.customers.Infrastructure.entity;

public class CustomerEntityConfiguration : IEntityTypeConfiguration<CustomerEntity>
{
    public void Configure(EntityTypeBuilder<CustomerEntity> builder)
    {
            builder.ToTable("customers");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.IsFrequent).HasColumnType("tinyint(1)");
 
            // Relación 1:1 con persons (la FK vive en customers)
            builder.HasOne(x => x.Person)
                   .WithOne(x => x.Customer)
                   .HasForeignKey<CustomerEntity>(x => x.PersonId);
        }


}
