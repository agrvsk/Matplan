using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class SkapaKonto_SKO
{
    public long SKO_RSN { get; set; }

    public string? SKO_NAMN { get; set; }

    public string? SKO_SIGNATUR { get; set; }

    public string? SKO_EMAIL { get; set; }

    public string? SKO_USERID { get; set; }

    public string? SKO_PWD1 { get; set; }

    public string? SKO_PWD2 { get; set; }

    public string? SKO_MEDDELANDE { get; set; }
}
