using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.personPlans.Infrastructure.entity;

public class PersonPlanEntityConfiguration: IEntityTypeConfiguration<PersonPlanEntity>
{
    public void Configure(EntityTypeBuilder<PersonPlanEntity> builder)
    {
            builder.ToTable("person_plans");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.CreditsGranted)
                   .HasColumnType("DECIMAL(10,2)");
 
            builder.Property(x => x.UnitPriceAtPurchase)
                   .HasColumnType("DECIMAL(10,2)");
 
            builder.Property(x => x.PurchasedAt)
                   .HasColumnType("DATETIME");
 
            builder.HasOne(x => x.Person)
                   .WithMany()
                   .HasForeignKey(x => x.PersonId);
 
            builder.HasOne(x => x.Plan)
                   .WithMany(x => x.PersonPlans)
                   .HasForeignKey(x => x.PlanId);
 
            builder.HasOne(x => x.Payment)
                   .WithMany()
                   .HasForeignKey(x => x.PaymentId);
        }

}
