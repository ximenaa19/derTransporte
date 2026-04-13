using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.chatRoom.Infrastructure.entity;

public class ChatRoomEntityConfiguration : IEntityTypeConfiguration<ChatRoomEntity>
{
    public void Configure(EntityTypeBuilder<ChatRoomEntity> builder)
    {
            builder.ToTable("chat_rooms");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.CreatedAt).HasColumnType("TIMESTAMP");
 
            builder.HasOne(x => x.Load)
                   .WithMany()
                   .HasForeignKey(x => x.LoadId);
 
            builder.HasOne(x => x.Trip)
                   .WithMany()
                   .HasForeignKey(x => x.TripId);
 
            /*builder.HasOne(x => x.Status)
                   .WithMany()
                   .HasForeignKey(x => x.StatusId);*/
        }

}
