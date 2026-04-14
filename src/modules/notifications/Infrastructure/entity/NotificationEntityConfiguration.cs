using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.notifications.Infrastructure.entity;

public class NotificationEntityConfiguration: IEntityTypeConfiguration<NotificationEntity>
{
    public void Configure(EntityTypeBuilder<NotificationEntity> builder)
    {
            builder.ToTable("notifications");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Title).IsRequired().HasColumnType("VARCHAR(100)");
            builder.Property(x => x.Body).HasColumnType("TEXT");
            builder.Property(x => x.LinkUrl).HasColumnType("VARCHAR(100)");
            builder.Property(x => x.IsRead).HasColumnType("tinyint");
            builder.Property(x => x.CreatedAt).HasColumnType("TIMESTAMP");
 
            builder.HasOne(x => x.Person)
                   .WithMany()
                   .HasForeignKey(x => x.PersonId);
 
            builder.HasOne(x => x.NotificationType)
                   .WithMany()
                   .HasForeignKey(x => x.NotificationTypeId);
        }

}
