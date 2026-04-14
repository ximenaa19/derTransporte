using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.cityPricingRules.Infrastructure.entity;

public class CityPricingRuleEntityConfiguration: IEntityTypeConfiguration<CityPricingRuleEntity>
{
    public void Configure(EntityTypeBuilder<CityPricingRuleEntity> builder)
    {
            builder.ToTable("city_pricing_rules");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.BaseCreditPrice)
                   .IsRequired()
                   .HasColumnType("DECIMAL(10,2)");
 
            builder.Property(x => x.IsActive)
                   .HasColumnType("TINYINT(1)");
 
            builder.HasOne(x => x.City)
                   .WithMany()
                   .HasForeignKey(x => x.CityId);
        }


}
