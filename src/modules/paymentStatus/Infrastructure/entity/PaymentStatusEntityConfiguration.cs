using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.paymentStatus.Infrastructure.entity;

public class PaymentStatusEntityConfiguration : IEntityTypeConfiguration<PaymentStatusEntity>
{
    public void Configure(EntityTypeBuilder<PaymentStatusEntity> builder)
    {
            builder.ToTable("payment_statuses");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
        }

}
