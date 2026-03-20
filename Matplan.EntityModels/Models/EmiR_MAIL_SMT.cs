using System;
using System.Collections.Generic;

namespace Matplan.EntityModels.Models;

public partial class EmiR_MAIL_SMT
{
    public long SMT_RSN { get; set; }

    public string? SMT_RecipientsTo { get; set; }

    public string? SMT_RecipientsCC { get; set; }

    public string? SMT_Subject { get; set; }

    public string? SMT_MsgText { get; set; }

    public string? SMT_AttachFiles { get; set; }

    public string? SMT_Status { get; set; }

    public DateTime? SMT_DateTime { get; set; }

    public string? SMT_User { get; set; }
}
