using System;
using derTransporte.src.modules.loads.Infrastructure.entity;

namespace derTransporte.src.modules.loadDetails.Infrastructure.entity;

public class LoadDetailsEntity
{
    public Guid Id { get; set; }
        public bool RequiresPackaging { get; set; }      // TINYINT(1)
        public bool IsFragile { get; set; }              // TINYINT(1)
        public bool IsStackable { get; set; }            // TINYINT(1)
        public bool RequiredInsurance { get; set; }      // TINYINT(1)
        public string SpecialInstructions { get; set; }= string.Empty;            // TEXT
        public string Metadata { get; set; }  = string.Empty;           
        public Guid LoadId { get; set; }                 // FK → loads
 
        public LoadEntity? Load { get; set; }

}
