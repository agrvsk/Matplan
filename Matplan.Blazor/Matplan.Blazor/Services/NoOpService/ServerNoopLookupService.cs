using Matplan.Blazor.Client.Services;
using Matplan.Shared.KodtabellDtos;

namespace Matplan.Blazor.Services.NoOpService;

public class ServerNoopLookupService : ILookupService
{
    public Task<List<KodtabellByteDto>?> GetCategoriesAsync() => Task.FromResult<List<KodtabellByteDto>?>(default);

    public Task<List<KodtabellStringDto>?> GetCategoriesAsync2() => Task.FromResult<List<KodtabellStringDto>?>(default);
}
