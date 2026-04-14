using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.payments.Infrastructure.entity;

public class PaymenEntityConfiguration : IEntityTypeConfiguration<PaymentEntity>
{
    public void Configure(EntityTypeBuilder<PaymentEntity> builder)
    {
            builder.ToTable("payments");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.ExternalReference).HasColumnType("VARCHAR(150)");
            builder.Property(x => x.AmountMoney).HasColumnType("DECIMAL");
            builder.Property(x => x.CreatedAt).HasColumnType("TIMESTAMP");
 
            builder.HasOne(x => x.Wallet)
                   .WithMany(x => x.Payments)
                   .HasForeignKey(x => x.WalletId);
 
            builder.HasOne(x => x.PaymentProvider)
                   .WithMany()
                   .HasForeignKey(x => x.PaymentProviderId);
 
            builder.HasOne(x => x.Status)
                   .WithMany()
                   .HasForeignKey(x => x.StatusId);
        }

}
