using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.countries.Infrastructure.entity;

public class CountriesEntityConfiguration : IEntityTypeConfiguration<CountriesEntity>
{
    public void Configure(EntityTypeBuilder<CountriesEntity> builder)
        {
            builder.ToTable("countries");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.IsoCode)
                   .IsRequired()
                   .HasColumnType("char(3)")
                   .HasMaxLength(3);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("varchar(60)")
                   .HasMaxLength(60);
 
            builder.Property(x => x.PhoneCode)
                   .HasColumnType("varchar(5)")
                   .HasMaxLength(5);
 
            // Índice único en isocode
            builder.HasIndex(x => x.IsoCode)
                   .IsUnique();
 
            // Relación: un country tiene muchos states
            /*builder.HasMany(x => x.statesOrRegions)
                   .WithOne(x => x.Country)
                   .HasForeignKey(x => x.CountryId);*/
        }

}
