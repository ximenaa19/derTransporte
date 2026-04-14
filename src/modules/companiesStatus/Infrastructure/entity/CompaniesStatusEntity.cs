using System;

namespace derTransporte.src.modules.companiesStatus.Infrastructure.entity;

public class CompaniesStatusEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;                // VARCHAR(100)
        public string Description { get; set; } = string.Empty;          // TEXT

}
