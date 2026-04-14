using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.chatMessages.Infrastructure.entity;

public class ChatMessageEntityConfiguration: IEntityTypeConfiguration<ChatMessageEntity>
{
    public void Configure(EntityTypeBuilder<ChatMessageEntity> builder)
    {
            builder.ToTable("chat_messages");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.MessageContent)
                   .IsRequired()
                   .HasColumnType("TEXT");
 
            builder.Property(x => x.IsRead)
                   .HasColumnType("TINYINT(1)");
 
            builder.Property(x => x.CreatedAt)
                   .HasColumnType("DATETIME");
 
            builder.HasOne(x => x.ChatRoom)
                   .WithMany(x => x.Messages)
                   .HasForeignKey(x => x.ChatRoomId);
 
            builder.HasOne(x => x.Sender)
                   .WithMany()
                   .HasForeignKey(x => x.SenderId);
 
            /*builder.HasOne(x => x.MessageType)
                   .WithMany()
                   .HasForeignKey(x => x.MessageTypeId);*/
        }

}
