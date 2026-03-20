using System.Linq.Expressions;

namespace Matplan.EntityContracts.Repositories.Shared;

public interface IRepositoryBase<T> where T : class
{
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
    IQueryable<T> FindAll(bool trackChanges = false);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges = false);
    //void DiscardChanges<TEntity>(TEntity entity) where TEntity : class;

}