using System;
using derTransporte.src.modules.stateOrRegions.Infrastructure.entity;

namespace derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;

public class CityOrMunicipalityEntity

{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty ;           // VARCHAR
        public string Code { get; set; } = string.Empty ;            // VARCHAR 
        public Guid StateRegId { get; set; }    
        public string? Coordinates { get; set; }    // VARCHAR
 
        // Navigation properties
        public StateOrRegionsEntity? StateOrRegion { get; set; }

}
