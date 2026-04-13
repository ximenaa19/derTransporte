using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;

public class CityOrMunicipalityEntityConfiguration : IEntityTypeConfiguration<CityOrMunicipalityEntity>
{
    public void Configure(EntityTypeBuilder<CityOrMunicipalityEntity> builder)
    {
        builder.ToTable("cityOrMunicipality");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(60);
            builder.Property(e => e.Code).HasMaxLength(10);
            builder.Property(e => e.StateRegId).HasColumnName("stateRegId");
            builder.Property(e => e.Coordinates)
                   .HasMaxLength(100)
                   .IsRequired(false);

            builder.HasIndex(x => x.Code).IsUnique();

            builder.HasOne(e => e.StateOrRegion).WithMany(s => s.CitiesOrMunicipalities).HasForeignKey(e => e.StateRegId).OnDelete(DeleteBehavior.Cascade);

    }

}
