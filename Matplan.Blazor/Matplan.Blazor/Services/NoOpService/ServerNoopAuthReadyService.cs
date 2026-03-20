using Matplan.Blazor.Client.Services;

namespace Matplan.Blazor.Services.NoOpService;

public sealed class ServerNoopAuthReadyService : IAuthReadyService
{
    public Task WaitAsync(CancellationToken ct = default) => Task.CompletedTask;
}
