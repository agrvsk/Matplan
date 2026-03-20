using System;
using System.Collections.Generic;
using System.Text;

namespace Matplan.Shared.EntityDtos;

public record ArtikelDto
{
    public long ART_ArtikelNr { get; set; }

    public long ART_USR_Rsn { get; set; }

    public long? ART_ART_ArtikelNr { get; set; }

    public string? ART_ArtikelNamn { get; set; }

    public int? ART_LagerSaldo { get; set; }

    public int? ART_LagersaldoUt { get; set; }

    public int? ART_MinLager { get; set; }

    public int? ART_Ledtid { get; set; }

    public string? ART_Memo { get; set; }

    public int? ART_Typ { get; set; }

    public string? ART_Lagring { get; set; }

    public DateTime? ART_BastForeDatum { get; set; }

    public string? ART_Enhet { get; set; }

    public int? ART_Pris { get; set; }

    public int? ART_PrisFrp { get; set; }

    public int? ART_Belopp { get; set; }

    public string? ART_AltBild { get; set; }

    public string? ART_ImgTyp { get; set; }

    public byte? ART_VideoJa { get; set; }

    public string? ART_UserNy { get; set; }

    public DateTime? ART_DateNy { get; set; }

    public string? ART_UserMod { get; set; }

    public DateTime? ART_DateMod { get; set; }

    public string? ART_HI { get; set; }

    public string? ART_VG { get; set; }

    public string? ART_Kat { get; set; }

    public byte? ART_Klassisk { get; set; }

    public byte? ART_Fettsnalt { get; set; }

    public byte? ART_GI { get; set; }

    public byte? ART_GL { get; set; }

    public byte? ART_Vego { get; set; }

    public byte? ART_Husman { get; set; }

    public byte? ART_Laktosfritt { get; set; }

    public byte? ART_LCHF { get; set; }

    public byte? ART_Glutenfritt { get; set; }

    public int? ART_GramPerDl { get; set; }

    public int? ART_GramPerSt { get; set; }

    public int? ART_GramPerTsk { get; set; }

    public int? ART_Forslag { get; set; }

    public int? ART_Sats { get; set; }

    public int? ART_LagerBelopp { get; set; }

    public byte? ART_JustVeckodag { get; set; }

    public int? ART_BehovTot { get; set; }

    public string? ART_KlientNamn { get; set; }

    public string? ART_URL_Link { get; set; }

    public string? ART_URL_Text { get; set; }

    public string? ART_URL { get; set; }

    public int? ART_Publicera { get; set; }

    public byte? ART_Aktuell { get; set; }

    public int? ART_ForslagIdag { get; set; }

    public int? ART_DaglForbr { get; set; }

    public DateTime? ART_DateUppdat { get; set; }

    public int? ART_Inkop { get; set; }

    public byte? ART_OpOrdNrLast { get; set; }

    public string? ART_FlashAdd { get; set; }

    public DateTime? ART_PrisDatum { get; set; }

    public int? ART_Losvikt { get; set; }

    public string? ART_Grupp { get; set; }

    public int? ART_IngariAnt { get; set; }

    public long? ART_AnsvUser { get; set; }

    public long? ART_ProduktArtikelNr { get; set; }

    public string? ART_ProduktArtikelNamn { get; set; }

    public int? ART_AntalBlogposter { get; set; }

    public string? ART_InkopEnhet { get; set; }

    public string? ART_LagerSaldoSt { get; set; }

    public int? ART_AntDAP { get; set; }

    public int? ART_AntBOM { get; set; }

    public int? ART_FinnsAlltidHemma { get; set; }

    public int? ART_DAP_Kvantitet { get; set; }

    public int? ART_BeloppFinns { get; set; }

    public int? ART_RankProcFinns { get; set; }

    public int? ART_USK_KvantitetForslag { get; set; }

    public int? ART_AktDagar { get; set; }

    public int? ART_Rang { get; set; }

    public string? ART_Sok { get; set; }

    public string? ART_Sok_Ravaror { get; set; }

    public int? ART_kCal { get; set; }

    public int? ART_kCalSum { get; set; }

    public int? ART_kCalFormula { get; set; }

    public byte? ART_TillPlan { get; set; }

    public DateTime? ART_AgentDatum { get; set; }

    public string? ART_Upload { get; set; }

    public byte[]? ART_Image { get; set; }

}
