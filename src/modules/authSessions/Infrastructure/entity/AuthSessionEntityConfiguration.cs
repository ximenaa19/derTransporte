using System;
using derTransporte.src.modules.authSessions.Infrastructure.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.auditLog.Infrastructure.entity;

public class AuthSessionEntityConfiguration : IEntityTypeConfiguration<AuthSessionEntity>
{
    public void Configure(EntityTypeBuilder<AuthSessionEntity> builder)
    {
            builder.ToTable("auth_sessions");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.RefreshToken)
                   .IsRequired()
                   .HasColumnType("TEXT");
 
            builder.Property(x => x.ExpiresAt)
                   .IsRequired()
                   .HasColumnType("DATETIME");
 
            builder.Property(x => x.IpAddress)
                   .HasColumnType("VARCHAR(45)");
 
            builder.Property(x => x.DeviceInfo)
                   .HasColumnType("TEXT");
 
            builder.Property(x => x.CreatedAt)
                   .HasColumnType("DATETIME");
 
            builder.HasOne(x => x.Person)
                   .WithMany()
                   .HasForeignKey(x => x.PersonId);
        }

}
