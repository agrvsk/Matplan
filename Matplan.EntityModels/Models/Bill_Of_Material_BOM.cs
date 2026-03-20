using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class Bill_Of_Material_BOM
{
    public long BOM_ArtikelNr { get; set; }

    public long? BOM_IngArtikelNr { get; set; }

    public long? BOM_ART_IngArtikelNr { get; set; }

    public long? BOM_USR_Rsn { get; set; }

    public int? BOM_Kvant { get; set; }

    public int? BOM_ArtTyp { get; set; }

    public int? BOM_IngArtTyp { get; set; }

    public int? BOM_IngPris { get; set; }

    public int? BOM_Belopp { get; set; }

    public string? BOM_IngEnhet { get; set; }

    public int? BOM_RecKvant { get; set; }

    public byte? BOM_RecEnh { get; set; }

    public string? BOM_Anm { get; set; }

    public string? BOM_Memo { get; set; }

    public byte BOM_OpNr { get; set; }

    public byte? BOM_JustVeckodag { get; set; }

    public byte BOM_OpOrdNr { get; set; }

    public DateTime? BOM_DateTimeStamp { get; set; }

    public int? BOM_Sats { get; set; }

    public int? BOM_IngSats { get; set; }

    public byte? BOM_Maltid { get; set; }

    public byte? BOM_Matratt { get; set; }

    public int? BOM_USK_KvantitetForslag { get; set; }

    public int? BOM_BeloppIngFinns { get; set; }

    public int? BOM_BeloppFinns { get; set; }

    public int? BOM_IngkCal { get; set; }

    public int? BOM_kCal { get; set; }
}
