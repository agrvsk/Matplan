using Matplan.Shared.EntityDtos;
using Matplan.Shared.Enums;
using Matplan.Shared.KodtabellDtos;
using Matplan.Shared.Paginering;
using Microsoft.AspNetCore.Components.Authorization;

namespace Matplan.Blazor.Client.Services;

public class LookupService : ILookupService
{
    private readonly IApiService _apiService;

    public LookupService(IApiService myApi)
    {
        _apiService = myApi;
    }

    private List<KodtabellByteDto>? _MaltidsVal { get; set; }
    private List<KodtabellStringDto>? _VarugruppsVal { get; set; }
    
    public async Task<List<KodtabellByteDto>?> GetCategoriesAsync()
    {
        return _MaltidsVal ??= await LoadPage(ByteKodtabeller.Z_Maltid, 1);
    }
    
    public async Task<List<KodtabellStringDto>?> GetCategoriesAsync2()
    {
        return _VarugruppsVal ??= await LoadPage(StringKodtabeller.Z_VG, 1);
    }





    private async Task<List<KodtabellByteDto>?> LoadPage(ByteKodtabeller byteKodtabell, int pageNumber )
    {
        try
        {
            var result = await _apiService.CallApiGetAsync<PagedResponse<KodtabellByteDto>>(
                $"api/Kodtabell/Byte?pageNumber={pageNumber}&pageSize=10&ByteKodtabell={byteKodtabell}");

            _MaltidsVal = result?.Items.ToList();
            return result?.Items.ToList();
            //meta = result?.MetaData;
        }
        catch (HttpRequestException apiEx)
        {
            //errorMessage = $"API Error: {apiEx.StatusCode} - {apiEx.Message}";
            Console.WriteLine("API error: " + apiEx.Message);
        }
        return null;
    }
    private async Task<List<KodtabellStringDto>?> LoadPage(StringKodtabeller stringKodtabell, int pageNumber)
    {
        try
        {

            var result = await _apiService.CallApiGetAsync<PagedResponse<KodtabellStringDto>>(
                $"api/Kodtabell/String?pageNumber={pageNumber}&pageSize=10&StringKodtabell={stringKodtabell}");

            _VarugruppsVal = result?.Items.ToList();
            return result?.Items.ToList();
            //meta = result?.MetaData;
        }
        catch (HttpRequestException apiEx)
        {
            //errorMessage = $"API Error: {apiEx.StatusCode} - {apiEx.Message}";
            Console.WriteLine("API error: " + apiEx.Message);
        }
        return null;
    }




}
