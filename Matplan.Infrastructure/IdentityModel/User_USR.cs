using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Matplan.Infrastructure.IdentityModel;

public partial class User_USR : IdentityUser
{
    //public long USR_Rsn { get; set; }
    public override string Id { get; set; } = string.Empty;

    public int? USR_KostnadSEK { get; set; }

    public int? USR_AttHandlaSEK { get; set; }

    public int? USR_LagerSEK { get; set; }

    public string? USR_Signatur { get; set; }

    public string? USR_Login { get; set; }

    public string? USR_Passord { get; set; }

    public string? USR_Roll { get; set; }

    public string? USR_Passord1 { get; set; }

    public long? USR_USK_Rsn { get; set; }

    public long? USR_Noterat_BLG_Rsn { get; set; }

    public bool? USR_Noterat_BLG { get; set; }

    public DateTime? USR_Timestamp { get; set; }

    public int? USR_BristViaMail { get; set; }

    public string? USR_MailKlockSlag { get; set; }

    public string? USR_Email { get; set; }

    public string? USR_Mail_Skickat { get; set; }

    public int? USR_BristViaSMS { get; set; }

    public string? USR_SMSKlockslag { get; set; }

    public string? USR_MobilTelNr { get; set; }

    public string? USR_SMS_Skickat { get; set; }

    public int? USR_URLTillMobil { get; set; }

    public string? USR_Mail_Skickat_Text { get; set; }

    public string? USR_SMS_Skickat_Text { get; set; }

    //IdentityUser kräver
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpireTime { get; set; }

}
