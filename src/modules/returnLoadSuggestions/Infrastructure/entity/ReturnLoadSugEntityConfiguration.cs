using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.returnLoadSuggestions.Infrastructure.entity;

public class ReturnLoadSugEntityConfiguration: IEntityTypeConfiguration<ReturnLoadSugEntity>
{
    public void Configure(EntityTypeBuilder<ReturnLoadSugEntity> builder)
    {
            builder.ToTable("return_load_suggestions");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Score)
                   .HasColumnType("DECIMAL(5,2)");
 
            builder.HasOne(x => x.Driver)
                   .WithMany()
                   .HasForeignKey(x => x.DriverId);
 
            // Dos FK a la misma tabla loads → nombrar constraints
            builder.HasOne(x => x.CurrentLoad)
                   .WithMany()
                   .HasForeignKey(x => x.CurrentLoadId)
                   .HasConstraintName("FK_return_suggestions_current_load");
 
            builder.HasOne(x => x.SuggestedLoad)
                   .WithMany()
                   .HasForeignKey(x => x.SuggestedLoadId)
                   .HasConstraintName("FK_return_suggestions_suggested_load");
        }

}
