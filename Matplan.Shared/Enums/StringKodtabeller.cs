using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Matplan.Shared.Enums;

//Z_VG        string:Storedpfu string?:DisplayedVG
//Z_Kat       string:Storedpfu string?:Displayed
//Z_HI        string:Storedpfu string?:Displayed
//Z_ART_Typ   string:Storedpfu string?:Displayed
//Z_ART_Lagring   string:Storedpfu string?:Displayed
//Z_ART_Grupp string:Storedpfu string?:Displayed

//Z_Datum     DateTime:Datum string?:Dag

//Z_ART_Enhet string:Storedpfu
//Z_AltBild   string:Storedpfu

public enum StringKodtabeller
{
    [Display(Name = "Varugrupp")] Z_VG,
    [Display(Name = "Kategori")] Z_Kat,
    [Display(Name = "Z_HI")] Z_HI,
    [Display(Name = "Z_ART_Typ")] Z_ART_Typ,
    [Display(Name = "Z_ART_Lagring")] Z_ART_Lagring,
    [Display(Name = "Z_ART_Grupp")] Z_ART_Grupp,

    [Display(Name = "Z_ART_Enhet")] Z_ART_Enhet,
    [Display(Name = "Z_AltBild")] Z_AltBild

}
