using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class Blog_BLG
{
    public long BLG_Rsn { get; set; }

    public DateTime? BLG_Datum { get; set; }

    public string? BLG_Signatur { get; set; }

    public string? BLG_DatumUser { get; set; }

    public string? BLG_Amne { get; set; }

    public long? BLG_OrgArtikelNr { get; set; }

    public string? BLG_Text { get; set; }

    public long? BLG_RelRsn { get; set; }

    public string? BLG_RelAmne { get; set; }

    public long? BLG_USR_Rsn { get; set; }

    public int? BLG_Gilla { get; set; }
}
