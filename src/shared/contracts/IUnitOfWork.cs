using System;

namespace derTransporte.src.shared.contracts;

public interface IUnitOfWork
{
    Task <int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

