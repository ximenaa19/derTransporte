using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.creditWallet.Infrastructure.entity;

public class CreditWalletEntityConfiguration : IEntityTypeConfiguration<CreditWalletEntity>
{
    public void Configure(EntityTypeBuilder<CreditWalletEntity> builder)
    {
            builder.ToTable("credit_wallet");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Balance).HasColumnType("DECIMAL");
            builder.Property(x => x.LastUpdate).HasColumnType("TIMESTAMP");
 
            builder.HasOne(x => x.Person)
                   .WithMany()
                   .HasForeignKey(x => x.PersonId);
 
            builder.HasOne(x => x.Company)
                   .WithMany()
                   .HasForeignKey(x => x.CompanyId);
        }
}
