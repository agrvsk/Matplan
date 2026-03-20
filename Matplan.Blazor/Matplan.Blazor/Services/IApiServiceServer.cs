namespace Matplan.Blazor.Services;

public interface IApiServiceServer
{
    public Task<T?> CallApiGetAsync<T>(string endpoint, CancellationToken ct = default);
    public Task<PagedResponse<T>?> CallApiGetPagedAsync<T>(string endpoint, CancellationToken ct = default);

}