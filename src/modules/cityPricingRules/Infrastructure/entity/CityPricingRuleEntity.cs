using System;
using derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;

namespace derTransporte.src.modules.cityPricingRules.Infrastructure.entity;

public class CityPricingRuleEntity
{
    public Guid Id { get; set; }
        public decimal BaseCreditPrice { get; set; }     // DECIMAL(10,2)
        public bool IsActive { get; set; }               // TINYINT(1)
        public Guid CityId { get; set; }                 // FK → citiesormunicipalities
 
        public CityOrMunicipalityEntity? City { get; set; }

}
