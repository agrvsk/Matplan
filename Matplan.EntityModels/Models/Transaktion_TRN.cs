using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class Transaktion_TRN
{
    public DateTime TRN_DateTime { get; set; }

    public long? TRN_USR_Rsn { get; set; }

    public long? TRN_USK_Rsn { get; set; }

    public string? TRN_USR_Signatur { get; set; }

    public string? TRN_USK_Namn { get; set; }

    public string? TRN_Sok { get; set; }

    public string? TRN_RemoteAddr { get; set; }

    public string? TRN_RemoteStad { get; set; }

    public string? TRN_RemoteRegion { get; set; }

    public string? TRN_RemoteLandkod { get; set; }
}
