using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.statusChat.Infrastructure.entity;

public class StatusChatEntityConfiguration : IEntityTypeConfiguration<StatusChatEntity>
{
    public void Configure(EntityTypeBuilder<StatusChatEntity> builder)
    {
            builder.ToTable("status_chat");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
