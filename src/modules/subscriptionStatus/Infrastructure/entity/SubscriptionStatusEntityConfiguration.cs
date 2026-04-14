using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.subscriptionStatus.Infrastructure.entity;

public class SubscriptionStatusEntityConfiguration : IEntityTypeConfiguration<SubscriptionStatusEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionStatusEntity> builder)
    {
            builder.ToTable("subscription_status");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
