using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.auditLog.Infrastructure.entity;

public class AuditLogEntityConfiguration: IEntityTypeConfiguration<AuditLogEntity>
{
    public void Configure(EntityTypeBuilder<AuditLogEntity> builder)
    {
            builder.ToTable("audit_log");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Action)
                   .IsRequired()
                   .HasColumnType("VARCHAR(50)");
 
            builder.Property(x => x.TableName)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.RecordId)
                   .HasColumnType("CHAR(36)");
 
            // JSON reemplaza JSONB en MySQL
            builder.Property(x => x.OldValues)
                   .HasColumnType("JSON");
 
            builder.Property(x => x.NewValues)
                   .HasColumnType("JSON");
 
            builder.Property(x => x.IpAddress)
                   .HasColumnType("VARCHAR(45)");
 
            builder.Property(x => x.UserAgent)
                   .HasColumnType("TEXT");
 
            builder.Property(x => x.CreatedAt)
                   .HasColumnType("DATETIME");
 
            builder.HasOne(x => x.User)
                   .WithMany()
                   .HasForeignKey(x => x.UserId);
        }
    

}
