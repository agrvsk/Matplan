using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class KalendarisktLagerSaldo_KLS
{
    public long KLS_User { get; set; }

    public long KLS_ArtikelNr { get; set; }

    public DateTime KLS_Datum { get; set; }

    public long? KLS_RelUser { get; set; }

    public long? KLS_RelArtikelNr { get; set; }

    public DateTime? KLS_RelDatum { get; set; }

    public int? KLS_SLD_Forslag { get; set; }

    public int? KLS_ART_Losvikt { get; set; }

    public int? KLS_SatsLosvikt { get; set; }

    public int? KLS_LagerSaldo { get; set; }

    public int? KLS_IngSaldo { get; set; }

    public int? KLS_DAPIn { get; set; }

    public int? KLS_BOMUt { get; set; }

    public int? KLS_MinLager { get; set; }

    public int? KLS_AntBBM { get; set; }

    public int? KLS_KalSaldo { get; set; }

    public int? KLS_Behov { get; set; }

    public int? KLS_Forslag { get; set; }

    public int? KLS_KalSaldoUt { get; set; }

    public int? KLS_BehovRepl { get; set; }

    public DateTime? KLS_BestDatum { get; set; }

    public long? KLS_ART_Ledtid { get; set; }

    public string? KLS_Dag { get; set; }

    public string? KLS_Manad { get; set; }

    public int? KLS_Vecka { get; set; }

    public string? KLS_Enhet { get; set; }

    public int? KLS_ForslagSEK { get; set; }

    public int? KLS_BehovSEK { get; set; }

    public int? KLS_ArtTyp { get; set; }

    public int? KLS_BehovTot { get; set; }

    public string? KLS_KlientNamn { get; set; }

    public bool? KLS_PubliceraRelKonstant { get; set; }

    public int? KLS_TillvFobrukatNu { get; set; }

    public int? KLS_TillvLagerNu { get; set; }

    public DateTime? KLS_DateStamp { get; set; }

    public int? KLS_DaglForbr { get; set; }

    public int? KLS_SLD_DaglForbr { get; set; }

    public long? KLS_ART_ART_ArtikelNr { get; set; }

    public int KLS_ART_Inkop { get; set; }

    public string? KLS_ART_InkopEnhet { get; set; }

    public byte? KLS_Forslag_OK { get; set; }

    public int? KLS_GramPerDl { get; set; }

    public int? KLS_GramPerSt { get; set; }

    public string? KLS_ForslagInkopEnhet { get; set; }

    public string? KLS_ForslagInkopSEK { get; set; }

    public string? KLS_KalSaldoStr { get; set; }

    public string? KLS_BehovInkopEnhet { get; set; }

    public string? KLS_BOMUtInkopEnhet { get; set; }

    public string? KLS_BehovTotInkopEnhet { get; set; }

    public string? KLS_KalSaldoUtInkopEnhet { get; set; }

    public string? KLS_Rest_FattasKvar { get; set; }

    public int? KLS_Extra { get; set; }

    public int? KLS_ExtraSt { get; set; }

    public int? KLS_SaldoSt { get; set; }

    public string? KLS_ProduktArtikelNamn { get; set; }

    public string? KLS_UddaVecka { get; set; }

    public int? KLS_ART_Faktor { get; set; }

    public int? KLS_ART_Sats { get; set; }

    public int? KLS_ART_Pris { get; set; }

    public int? KLS_ART_PrisFrp { get; set; }

    public DateTime? KLS_ART_PrisDatum { get; set; }

    public long? KLS_ART_AnsvUser { get; set; }

    public int? KLS_SistaKLS { get; set; }

    public string? KLS_VG { get; set; }

    public int? KLS_ART_kCalFormula { get; set; }
}
