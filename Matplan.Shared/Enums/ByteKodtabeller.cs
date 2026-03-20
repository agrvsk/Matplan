using System.ComponentModel.DataAnnotations;

namespace Matplan.Shared.Enums;
//Z_Veckodag	byte:Storedpfu		string?:Displayed
//Z_Steg      byte:Storedpfu string?:Displayed
//Z_Plandag   byte:Storedpfu string?:Displayed
//Z_NejJa     byte:Storedpfu string?:Displayed
//Z_Matratt   byte:Storedpfu string?:Displayed
//Z_Maltid    byte:Storedpfu string?:Displayed
//Z_Ja        byte:Storedpfu string?:Displayed
//Z_Handlar   byte:Storedpfu string?:Displayed
//Z_BristViaSMS   byte:Storedpfu string?:Displayed
//Z_BeredInkop    byte:Storedpfu string?:Displayed
//Z_ART_RecEnh    byte:Storedpfu string?:Displayed

//Z_VG        string:Storedpfu string?:DisplayedVG
//Z_Kat       string:Storedpfu string?:Displayed
//Z_HI        string:Storedpfu string?:Displayed
//Z_ART_Typ   string:Storedpfu string?:Displayed
//Z_ART_Lagring   string:Storedpfu string?:Displayed
//Z_ART_Grupp string:Storedpfu string?:Displayed

//Z_Datum     DateTime:Datum string?:Dag

//Z_ART_Enhet string:Storedpfu
//Z_AltBild   string:Storedpfu

public enum ByteKodtabeller : byte
{
    [Display(Name = "Veckodag")] Z_Veckodag,
    [Display(Name = "Steg")] Z_Steg,
    [Display(Name = "Planeringsdag")] Z_Plandag,
    [Display(Name = "JaNej")] Z_NejJa,
    [Display(Name = "Maträtt")] Z_Matratt,
    [Display(Name = "Måltid")] Z_Maltid,
    [Display(Name = "Ja")] Z_Ja,
    [Display(Name = "Handlar")] Z_Handlar,
    [Display(Name = "Bristrapportering")] Z_BristViaSMS,
    [Display(Name = "BeredInköp")] Z_BeredInkop,
    [Display(Name = "Rekommenderad enhet")] Z_ART_RecEnh
}
