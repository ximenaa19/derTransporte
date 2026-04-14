using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.paymentProviders.Infrastructure.entity;

public class PaymentProviderEntityConfiguration : IEntityTypeConfiguration<PaymentProviderEntity>
{
    public void Configure(EntityTypeBuilder<PaymentProviderEntity> builder)
    {
            builder.ToTable("payment_providers");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
        }

}
