using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matplan.Shared.Enums;

namespace Matplan.Shared.Requests;

public class RequestParams
{
    [Range(1, int.MaxValue)]
    [DefaultValue(1)]
    public int PageNumber { get; set; } = 1;

    [Range(2, 200)]
    [DefaultValue(20)]
    public int PageSize { get; set; } = 20;
}
public class KodtabellByteRequestParams : RequestParams
{
    [Required]
    public ByteKodtabeller ByteKodtabell { get; set; }
    //private ByteKodtabeller bytekodtabell;
    //public ByteKodtabeller ByteKodtabell 
    //{ 
    //    get{ bytekodtabell = EnumDropdownHelper.ToDropdownList<ByteKodtabeller>(); }
    //    set; 
    //}


   // var list = EnumDropdownHelper.ToDropdownList<ByteKodtabeller>();
   //return Ok(list);
}
public class KodtabellStringRequestParams : RequestParams
{
    [Required]
    public StringKodtabeller StringKodtabell { get; set; } 
}
public class KodtabellDateRequestParams : RequestParams
{
}

public class ArtikelRequestParams : RequestParams
{
    ////[BindRequired] // Uncomment to make UserId required
    public string? Varugrupp { get; set; }
}
public class BomRequestParams : RequestParams
{

}

//public class Z_VeckodagRequestParams : RequestParams
//{ }
//public class Z_StegRequestParams : RequestParams 
//{ }
//public class Z_PlandagParams : RequestParams
//{ }
//public class Z_NejJaRequestParams : RequestParams
//{ }
//public class Z_MatrattRequestParams : RequestParams
//{ }
//public class Z_MaltidParams : RequestParams
//{ }
//public class Z_JaParams : RequestParams
//{ }
//public class Z_HandlarRequestParams : RequestParams
//{ }
//public class Z_BristViaSMSRequestParams : RequestParams
//{ }
//public class Z_BeredInkopRequestParams : RequestParams
//{ }
//public class Z_ART_RecEnhRequestParams : RequestParams
//{ }
//public class Z_VGRequestParams : RequestParams
//{ }
//public class Z_KatRequestParams : RequestParams
//{ }
//public class Z_HIRequestParams : RequestParams
//{ }
//public class Z_ART_TypRequestParams : RequestParams
//{ }

//public class Z_ART_LagringRequestParams : RequestParams
//{ }
//public class Z_ART_GruppRequestParams : RequestParams
//{ }
//public class Z_DatumRequestParams : RequestParams
//{ }
//public class Z_ART_EnhetRequestParams : RequestParams
//{ }
//public class Z_AltBildRequestParams : RequestParams
//{ }
//public class Z_JaRequestParams : RequestParams
//{ }
//public class Z_MaltidRequestParams : RequestParams
//{ }
//public class Z_PlandagRequestParams : RequestParams
//{ }



