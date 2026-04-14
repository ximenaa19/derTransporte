using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.messageType.Infrastructure.entity;

public class MessageTypeEntityConfiguration : IEntityTypeConfiguration<MessageTypeEntity>
{
    public void Configure(EntityTypeBuilder<MessageTypeEntity> builder)
    {
            builder.ToTable("message_type");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
