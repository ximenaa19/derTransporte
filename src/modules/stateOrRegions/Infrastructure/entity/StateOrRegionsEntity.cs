using System;
using derTransporte.src.modules.countries.Infrastructure.entity;

namespace derTransporte.src.modules.stateOrRegions.Infrastructure.entity;

public class StateOrRegionsEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty ;           // VARCHAR
        public string Code { get; set; } = string.Empty ;            // VARCHAR 
        public Guid CountryId { get; set; }          // FK → countries
 
        // Navigation properties
        public CountriesEntity? Country { get; set; }
        //public ICollection<CityOrMunicipalityEntity> CitiesOrMunicipalities { get; set; }

}
