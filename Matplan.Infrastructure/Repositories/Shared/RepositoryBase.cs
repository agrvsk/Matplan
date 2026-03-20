using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Matplan.Infrastructure.Data;
using Matplan.EntityContracts.Repositories.Shared;

namespace Matplan.Infrastructure.Repositories.Shared;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected MatplanDBContext Context { get; }
    protected DbSet<T> DbSet { get; }

    public RepositoryBase(MatplanDBContext context)
    {
        Context = context;
        DbSet = context.Set<T>();
    }

    public virtual void Insert(T entity)
    {
        DbSet.Add(entity);
    }
    public virtual void Update(T entity)
    {
        DbSet.Update(entity);
    }

    public virtual void Delete(T entity)
    {
        DbSet.Remove(entity);
    }

    public IQueryable<T> FindAll(bool trackChanges = false)
    {
        return trackChanges ? DbSet : DbSet.AsNoTracking();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges = false)
    {
        return trackChanges ? DbSet.Where(expression) : DbSet.Where(expression).AsNoTracking();
    }

    //public void DiscardChanges<TEntity>(TEntity entity) where TEntity : class
    //{
    //    var entry = Context.Entry(entity);

    //    // Om objektet inte trackas, inget att göra
    //    if (entry == null || entry.State == EntityState.Detached)
    //        return;

    //    // Återställ alla värden till original
    //    entry.CurrentValues.SetValues(entry.OriginalValues);

    //    // Sätt till Unchanged (ingen update sker)
    //    entry.State = EntityState.Unchanged;

    //    // Alternativ: helt ta bort tracking
    //    //entry.State = EntityState.Detached;
    //}

}
