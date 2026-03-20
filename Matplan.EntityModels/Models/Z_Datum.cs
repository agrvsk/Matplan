using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class Z_Datum
{
    public DateTime Datum { get; set; }

    public string? Dag { get; set; }
}
