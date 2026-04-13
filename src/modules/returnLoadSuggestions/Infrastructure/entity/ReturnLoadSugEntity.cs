using System;
using derTransporte.src.modules.drivers.Infrastructure.entity;
using derTransporte.src.modules.loads.Infrastructure.entity;

namespace derTransporte.src.modules.returnLoadSuggestions.Infrastructure.entity;

public class ReturnLoadSugEntity
{
    public Guid Id { get; set; }
        public decimal Score { get; set; }               // DECIMAL(5,2)
        public Guid DriverId { get; set; }               // FK → drivers
        public Guid CurrentLoadId { get; set; }          // FK → loads
        public Guid SuggestedLoadId { get; set; }        // FK → loads
 
        public DriverEntity? Driver { get; set; }
        public LoadEntity? CurrentLoad { get; set; }
        public LoadEntity? SuggestedLoad { get; set; }

}
