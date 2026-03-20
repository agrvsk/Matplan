using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class Klient_USK
{
    public long USK_Rsn { get; set; }

    public string? USK_Namn { get; set; }

    public int? USK_KvantitetForslag { get; set; }

    public int? USK_LagerSEK { get; set; }

    public int? USK_BristSEK { get; set; }

    public int? USK_KostnadSEK { get; set; }

    public byte? USK_HandlarMa { get; set; }

    public byte? USK_HandlarTi { get; set; }

    public byte? USK_HandlarOn { get; set; }

    public byte? USK_HandlarTo { get; set; }

    public byte? USK_HandlarFr { get; set; }

    public byte? USK_HandlarLo { get; set; }

    public byte? USK_HandlarSo { get; set; }

    public byte? USK_Handlar { get; set; }

    public DateTime? USK_LicensBetaldToM { get; set; }

    public string? USK_LicensBetaldStatus { get; set; }

    public int? USK_AntDAP { get; set; }
}
