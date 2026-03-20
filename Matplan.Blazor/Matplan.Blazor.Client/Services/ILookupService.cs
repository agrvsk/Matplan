using Matplan.Shared.KodtabellDtos;

namespace Matplan.Blazor.Client.Services;

public interface ILookupService
{
    public Task<List<KodtabellByteDto>?> GetCategoriesAsync();
    public Task<List<KodtabellStringDto>?> GetCategoriesAsync2();

}