using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class Behov_BOM_BBM
{
    public long BBM_User { get; set; }

    public long BBM_ArtikelNr { get; set; }

    public DateTime BBM_Datum { get; set; }

    public int? BBM_Kvant { get; set; }

    public long? BBM_IngArtikelNr { get; set; }

    public int? BBM_BehovRepl { get; set; }

    public int? BBM_Faktor { get; set; }

    public int? BBM_BOMUt { get; set; }

    public DateTime? BBM_IngDatum { get; set; }

    public long? BBM_IngUser { get; set; }

    public int? BBM_Ledtid { get; set; }

    public byte? BBM_JustVeckodag { get; set; }

    public int? BBM_RecKvant { get; set; }

    public byte? BBM_RecEnh { get; set; }

    public byte BBM_BOM_OpNr { get; set; }

    public byte BBM_BOM_OpOrdNr { get; set; }

    public int? BBM_Sats { get; set; }

    public int? BBM_BOMUtSEK { get; set; }

    public int? BBM_ART_FinnsAlltidHemma { get; set; }
}
