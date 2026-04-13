using System;

namespace derTransporte.src.modules.countries.Infrastructure.entity;

public class CountriesEntity
{
    public Guid Id { get; set; }
    public string IsoCode { get; set; } = string.Empty;     // CHAR - código ISO del país (ej: CO, US)
    public string Name { get; set; } = string.Empty ;           // VARCHAR
    public string PhoneCode { get; set; } = string.Empty ;      // VARCHAR - prefijo telefónico (ej: +57)
 
        // Navigation properties
    //public ICollection<stateOrRegionEntity> statesOrRegions { get; set; }

}
