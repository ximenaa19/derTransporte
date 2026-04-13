using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.countries.Infrastructure.entity;
using derTransporte.src.modules.stateOrRegions.Infrastructure.entity;
using derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;
using derTransporte.src.modules.drivers.Infrastructure.entity;
using derTransporte.src.modules.customers.Infrastructure.entity;
using derTransporte.src.modules.authCredentials.Infrastructure.entity;
using derTransporte.src.modules.transportCompanies.Infrastructure.entity;
using derTransporte.src.modules.vehicles.Infrastructure.entity;
using derTransporte.src.modules.loads.Infrastructure.entity;
using derTransporte.src.modules.bids.Infrastructure.entity;
using derTransporte.src.modules.trips.Infrastructure.entity;
using derTransporte.src.modules.creditWallet.Infrastructure.entity;
using derTransporte.src.modules.payments.Infrastructure.entity;
using derTransporte.src.modules.plans.Infrastructure.entity;
using derTransporte.src.modules.chatRoom.Infrastructure.entity;
using derTransporte.src.modules.disputes.Infrastructure.entity;
using derTransporte.src.modules.ratings.Infrastructure.entity;
using derTransporte.src.modules.notifications.Infrastructure.entity;

namespace derTransporte.src.shared.context;

public class AppDbContext : DbContext
{

    public DbSet<CountriesEntity> countries { get; set; } = null!;
    public DbSet<StateOrRegionsEntity> StateOrRegions { get; set; } = null!;
    public DbSet<CityOrMunicipalityEntity> CityOrMunicipality { get; set; } = null!;
    public DbSet<PersonEntity> Person { get; set; } = null!;
    public DbSet<DriverEntity> Driver { get; set; } = null!;
    public DbSet<CustomerEntity> Customer { get; set; } = null!;
    public DbSet<AuthCredentialEntity> AuthCredential { get; set; } = null!;
    public DbSet<transportCompanyEntity> transportCompany { get; set; } = null!;
    public DbSet<VehicleEntity> Vehicle { get; set; } = null!;
    public DbSet<LoadEntity> Load { get; set; } = null!;
    public DbSet<BidEntity> Bid { get; set; } = null!;
    public DbSet<TripEntity> Trip { get; set; } = null!;
    public DbSet<CreditWalletEntity> CreditWallet { get; set; } = null!;
    public DbSet<PaymentEntity> Payment { get; set; } = null!;
    public DbSet<PlanEntity> Plan { get; set; } = null!;
    public DbSet<ChatRoomEntity> ChatRooms { get; set; } = null!;
    
    public DbSet<DisputeEntity> Dispute { get; set; } = null!;
    
    public DbSet<RatingEntity> Rating { get; set; } = null!;
    public DbSet<NotificationEntity> Notification { get; set; } = null!;
    
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

}
