using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class Batch_BAT
{
    public long BAT_Id { get; set; }

    public string? BAT_Namn { get; set; }

    public long? BAT_AntalLoopar { get; set; }

    public int? BAT_Sleeptime { get; set; }

    public DateTime? BAT_SimDatum { get; set; }

    public byte? BAT_PayPal { get; set; }

    public byte? BAT_DIBS { get; set; }

    public byte? BAT_IPInfo { get; set; }

    public string? BAT_URL { get; set; }

    public string? BAT_SERVERPATH { get; set; }

    public bool? BAT_RESIZE { get; set; }

    public short? BAT_MAXWIDTH { get; set; }

    public short? BAT_MAXHEIGHT { get; set; }

    public bool? BAT_COMPRESS { get; set; }

    public decimal? BAT_QUALITY { get; set; }

    public bool? BAT_BASE64 { get; set; }

    public bool? BAT_CHMOD { get; set; }
}
