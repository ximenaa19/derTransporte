using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.chatParticipants.Infrastructure.entity;

public class ChatParticipantEntityConfiguration: IEntityTypeConfiguration<ChatParticipantEntity>
{
    public void Configure(EntityTypeBuilder<ChatParticipantEntity> builder)
    {
            builder.ToTable("chat_participants");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.JoinedAt)
                   .IsRequired()
                   .HasColumnType("DATETIME");
 
            // Índice único compuesto para evitar que una persona
            // esté dos veces en la misma sala
            builder.HasIndex(x => new { x.ChatRoomId, x.PersonId })
                   .IsUnique();
 
            builder.HasOne(x => x.ChatRoom)
                   .WithMany(x => x.Participants)
                   .HasForeignKey(x => x.ChatRoomId);
 
            builder.HasOne(x => x.Person)
                   .WithMany()
                   .HasForeignKey(x => x.PersonId);
        }

}
