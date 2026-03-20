using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Matplan.Shared.Paginering;

public class MetaData
{
    public int CurrentPage { get;  }
    public int TotalPages { get;  }
    public int PageSize { get; }
    public int TotalCount { get; }
    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;


    [JsonConstructor]
    public MetaData(int currentPage, int totalPages, int pageSize, int totalCount)
    {
        CurrentPage = currentPage;
        TotalPages = totalPages;
        PageSize = pageSize;
        TotalCount = totalCount;
    }
}