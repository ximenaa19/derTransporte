using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.transportCompanies.Infrastructure.entity;

public class transportCompanyEntityConfiguration: IEntityTypeConfiguration<transportCompanyEntity>
{
    public void Configure(EntityTypeBuilder<transportCompanyEntity> builder)
    {builder.ToTable("transport_companies");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name).IsRequired().HasColumnType("VARCHAR(50)");
            builder.Property(x => x.Nit).IsRequired().HasColumnType("VARCHAR(20)");
            builder.Property(x => x.EmailCorp).HasColumnType("VARCHAR(100)");
            builder.Property(x => x.ContactName).HasColumnType("VARCHAR(100)");
            builder.Property(x => x.ContactEmail).HasColumnType("VARCHAR(100)");
            builder.Property(x => x.ContactPhone).HasColumnType("VARCHAR(20)");
            builder.Property(x => x.Address).HasColumnType("TEXT");
            builder.Property(x => x.LogoUrl).HasColumnType("TEXT");
            builder.Property(x => x.VerifiedAt).HasColumnType("TIMESTAMP");
 
            // Índices únicos
            builder.HasIndex(x => x.Nit).IsUnique();
            builder.HasIndex(x => x.EmailCorp).IsUnique();
            builder.HasIndex(x => x.ContactEmail).IsUnique();
 
            // Relaciones N:1
            builder.HasOne(x => x.City)
                   .WithMany()
                   .HasForeignKey(x => x.CityId);
 
            builder.HasOne(x => x.Status)
                   .WithMany()
                   .HasForeignKey(x => x.StatusId);
 
            builder.HasOne(x => x.LegalRepresentative)
                   .WithMany()
                   .HasForeignKey(x => x.LegalRepresentativeId);

}}
