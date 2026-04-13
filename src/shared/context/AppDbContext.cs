using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.countries.Infrastructure.entity;
using derTransporte.src.modules.stateOrRegions.Infrastructure.entity;
using derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;
using derTransporte.src.modules.drivers.Infrastructure.entity;
using derTransporte.src.modules.customers.Infrastructure.entity;
using derTransporte.src.modules.authCredentials.Infrastructure.entity;

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
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

}
