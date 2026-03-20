using System;
using System.Collections.Generic;
using System.Text;

namespace Matplan.Shared.Paginering;

public class PagedResponse<T>
{
    public IEnumerable<T> Items { get; set; } = [];
    public MetaData MetaData { get; set; } = new(1, 1, 1, 1);
}

