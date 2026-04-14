using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.companiesStatus.Infrastructure.entity;

public class CompaniesStatusEntityConfiguration: IEntityTypeConfiguration<CompaniesStatusEntity>    
{
    public void Configure(EntityTypeBuilder<CompaniesStatusEntity> builder)
    {
            builder.ToTable("companies_status");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
