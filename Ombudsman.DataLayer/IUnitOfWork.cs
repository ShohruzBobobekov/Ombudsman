using Microsoft.EntityFrameworkCore.Storage;

namespace Ombudsman.DataLayer;

public interface IUnitOfWork
{
    AppDbContext Context { get; }
    IDbContextTransaction CurrencyTransaction { get; }
    TRepository GetRepository<TRepository>();
    Task<IDbContextTransaction> BeginTransaction();
    Task Save();
    Task Commit();
    Task Rollback();
}
