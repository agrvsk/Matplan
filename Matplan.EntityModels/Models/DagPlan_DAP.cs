using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class DagPlan_DAP
{
    public long? DAP_ArtikelNr { get; set; }

    public DateTime? DAP_Datum { get; set; }

    public int? DAP_Kvantitet { get; set; }

    public int? DAP_ArtTyp { get; set; }

    public string? DAP_FrTi { get; set; }

    public long? DAP_User { get; set; }

    public long DAP_Rsn { get; set; }

    public string? DAP_Dag { get; set; }

    public string? DAP_Enhet { get; set; }

    public int? DAP_SLD_Pris { get; set; }

    public int? DAP_SLD_Summa { get; set; }

    public int? DAP_Vecka { get; set; }

    public string? DAP_Manad { get; set; }

    public long? DAP_ART_ArtikelNr { get; set; }

    public string? DAP_ArtikelNamn { get; set; }

    public string? DAP_ImgTyp { get; set; }

    public string? DAP_AltBild { get; set; }

    public int? DAP_LagerSaldo { get; set; }

    public int? DAP_Sats { get; set; }

    public int? DAP_InkopBered { get; set; }

    public byte? DAP_Maltid { get; set; }

    public byte? DAP_Matratt { get; set; }

    public string? DAP_Anm { get; set; }

    public long? DAP_KLS_User { get; set; }

    public long? DAP_KLS_ArtikelNr { get; set; }

    public string? DAP_UddaVecka { get; set; }

    public int? DAP_ART_kCalFormula { get; set; }
}
