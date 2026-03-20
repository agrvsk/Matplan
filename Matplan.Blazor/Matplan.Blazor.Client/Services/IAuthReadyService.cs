namespace Matplan.Blazor.Client.Services;

public interface IAuthReadyService
{
    Task WaitAsync(CancellationToken ct = default);
}