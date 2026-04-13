using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.creditTransactions.Infrastructure.entity;

public class CreditTransactionEntityConfiguration: IEntityTypeConfiguration<CreditTransactionEntity>
{
    public void Configure(EntityTypeBuilder<CreditTransactionEntity> builder)
    {
            builder.ToTable("credit_transactions");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Amount)
                   .IsRequired()
                   .HasColumnType("DECIMAL(10,2)");
 
            builder.Property(x => x.BalanceAfter)
                   .IsRequired()
                   .HasColumnType("DECIMAL(10,2)");
 
            builder.Property(x => x.ReferenceId)
                   .HasColumnType("CHAR(36)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
 
            builder.Property(x => x.CreatedAt)
                   .HasColumnType("DATETIME");
 
            builder.HasOne(x => x.Wallet)
                   .WithMany(x => x.Transactions)
                   .HasForeignKey(x => x.WalletId);
 
            /*builder.HasOne(x => x.TransactionType)
                   .WithMany()
                   .HasForeignKey(x => x.TransactionTypeId);*/
        }

}
