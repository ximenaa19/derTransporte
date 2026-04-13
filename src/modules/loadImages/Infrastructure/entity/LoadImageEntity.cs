using System;
using derTransporte.src.modules.loads.Infrastructure.entity;

namespace derTransporte.src.modules.loadImages.Infrastructure.entity;

public class LoadImageEntity
{
    public Guid Id { get; set; }
        public string ImageUrl { get; set; }  = string.Empty;            // TEXT
        public string Description { get; set; }  = string.Empty;          // VARCHAR(255)
        public Guid LoadId { get; set; }                 // FK → loads
 
        public LoadEntity? Load { get; set; }

}
