using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.subscriptions.Infrastructure.entity;

public class SubscriptionEntityConfiguration: IEntityTypeConfiguration<SubscriptionEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionEntity> builder)
    {
            builder.ToTable("subscriptions");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.StartDate).HasColumnType("DATETIME");
            builder.Property(x => x.EndDate).HasColumnType("DATETIME");
            builder.Property(x => x.AutoRenew).HasColumnType("TINYINT(1)");
 
            builder.HasOne(x => x.Person)
                   .WithMany()
                   .HasForeignKey(x => x.PersonId);
 
            /*builder.HasOne(x => x.SubscriptionType)
                   .WithMany()
                   .HasForeignKey(x => x.SubscriptionTypeId);
 
            builder.HasOne(x => x.Status)
                   .WithMany()
                   .HasForeignKey(x => x.StatusId);*/
 
            builder.HasOne(x => x.Payment)
                   .WithMany()
                   .HasForeignKey(x => x.PaymentId);
        }

}
