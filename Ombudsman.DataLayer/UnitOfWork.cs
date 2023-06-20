using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace Ombudsman.DataLayer;

internal class UnitOfWork : IUnitOfWork
{
    public AppDbContext Context { get; set; }
    private readonly IServiceProvider _serviceProvider;
    public UnitOfWork(AppDbContext context, IServiceProvider serviceProvider)
    {
        Context=context;
        _serviceProvider=serviceProvider;
    }
    public TRepository GetRepository<TRepository>() => _serviceProvider.GetRequiredService<TRepository>();
    public IDbContextTransaction CurrencyTransaction => Context.Database.CurrentTransaction;

    public async Task<IDbContextTransaction> BeginTransaction()
    {
        Context.Database.CreateExecutionStrategy();
        return await Context.Database.BeginTransactionAsync();
    }

    public async Task Commit()
    {
        await Context.Database.CommitTransactionAsync();
    }

    public async Task Rollback()
    {
        await Context.Database.RollbackTransactionAsync();
    }

    public async Task Save()
    {
        await Context.SaveChangesAsync();
    }
}
