using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.personTransport.Infrastructure.entity;

public class PersonTransportEntityConfiguration: IEntityTypeConfiguration<PersonTransportEntity>
{
    public void Configure(EntityTypeBuilder<PersonTransportEntity> builder)
    {
            builder.ToTable("person_transport");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.IsActive)
                   .HasColumnType("TINYINT(1)");
 
            builder.Property(x => x.JoinedAt)
                   .IsRequired()
                   .HasColumnType("DATETIME");
 
            builder.HasOne(x => x.Person)
                   .WithMany()
                   .HasForeignKey(x => x.PersonId);
 
            builder.HasOne(x => x.Company)
                   .WithMany(x => x.PersonTransports)
                   .HasForeignKey(x => x.CompanyId);
 
            // N:1 → tipo de relación (catálogo)
            /*builder.HasOne(x => x.RelationType)
                   .WithMany()
                   .HasForeignKey(x => x.RelationTypeId);*/
        }
    

}
