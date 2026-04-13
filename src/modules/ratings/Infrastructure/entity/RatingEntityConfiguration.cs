using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.ratings.Infrastructure.entity;

public class RatingEntityConfiguration : IEntityTypeConfiguration<RatingEntity>
{
    public void Configure(EntityTypeBuilder<RatingEntity> builder)
    {
            builder.ToTable("ratings");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Score).HasColumnType("SMALLINT");
            builder.Property(x => x.Comment).HasColumnType("TEXT");
            builder.Property(x => x.CreatedAt).HasColumnType("TIMESTAMP");
 
            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.Ratings)
                   .HasForeignKey(x => x.TripId);
 
            // Dos FK a la misma tabla persons → nombrar constraints explícitamente
            builder.HasOne(x => x.Evaluator)
                   .WithMany()
                   .HasForeignKey(x => x.EvaluatorId)
                   .HasConstraintName("FK_ratings_evaluator");
 
            builder.HasOne(x => x.Evaluated)
                   .WithMany()
                   .HasForeignKey(x => x.EvaluatedId)
                   .HasConstraintName("FK_ratings_evaluated");
        }

}
