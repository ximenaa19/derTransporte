using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.plans.Infrastructure.entity;

public class PlanEntityConfiguration : IEntityTypeConfiguration<PlanEntity>
{
    public void Configure(EntityTypeBuilder<PlanEntity> builder)
    {
            builder.ToTable("plans");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name).IsRequired().HasColumnType("VARCHAR(30)");
            builder.Property(x => x.CreditAmount).HasColumnType("DECIMAL");
            builder.Property(x => x.Price).HasColumnType("DECIMAL");
            builder.Property(x => x.IsActive).HasColumnType("tinyint(1)");
        }

}
