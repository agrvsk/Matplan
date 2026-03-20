using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class ip2location_db5
{
    public long? ip_from { get; set; }

    public long? ip_to { get; set; }

    public string? country_code { get; set; }

    public string? country_name { get; set; }

    public string? region_name { get; set; }

    public string? city_name { get; set; }

    public double? latitude { get; set; }

    public double? longitude { get; set; }
}
