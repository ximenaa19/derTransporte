using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.subscriptionType.Infrastructure.entity;

public class SubscriptionTypeEntityConfiguration : IEntityTypeConfiguration<SubscriptionTypeEntity>
{
    public void Configure(EntityTypeBuilder<SubscriptionTypeEntity> builder)
    {
            builder.ToTable("subscription_type");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
