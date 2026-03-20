using Matplan.Shared.Paginering;

namespace Matplan.EntityContracts.Repositories.Shared;

public interface IPagedList<T>
{
    IReadOnlyList<T> Items { get; }
    MetaData MetaData { get; }

    // Om du vill att även fabriksmetoden ska vara del av kontraktet:
    // Task<IPagedList<T>> CreateAsync(IQueryable<T> source, int page
}