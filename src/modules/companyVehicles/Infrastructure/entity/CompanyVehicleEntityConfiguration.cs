using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.companyVehicles.Infrastructure.entity;

public class CompanyVehicleEntityConfiguration: IEntityTypeConfiguration<CompanyVehicleEntity>
{
    public void Configure(EntityTypeBuilder<CompanyVehicleEntity> builder)
    {
            builder.ToTable("company_vehicles");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.IsActive)
                   .HasColumnType("TINYINT(1)");
 
            builder.HasOne(x => x.Company)
                   .WithMany(x => x.CompanyVehicles)
                   .HasForeignKey(x => x.CompanyId);
 
            builder.HasOne(x => x.Vehicle)
                   .WithMany(x => x.CompanyVehicles)
                   .HasForeignKey(x => x.VehicleId);
        }

}
