using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.notificationType.Infrastructure.entity;

public class NotificationTypeEntityConfiguration : IEntityTypeConfiguration<NotificationTypeEntity>
{
    public void Configure(EntityTypeBuilder<NotificationTypeEntity> builder)
    {
            builder.ToTable("notification_type");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
