using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.transactionTypes.Infrastructure.entity;

public class TransactionTypeEntityConfiguration : IEntityTypeConfiguration<TransactionTypeEntity>
{
    public void Configure(EntityTypeBuilder<TransactionTypeEntity> builder)
    {
            builder.ToTable("transaction_types");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
        }

}
