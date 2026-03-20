using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Matplan.Shared.KodtabellDtos;
using Matplan.Shared.Requests;

namespace Matplan.Shared.Enums;


public static class EnumDropdownHelper
{
    public static List<KodtabellByteDto> ToDropdownList<TEnum>() where TEnum : Enum
    {
        return Enum.GetValues(typeof(TEnum))
            .Cast<TEnum>()
            .Select(x => new KodtabellByteDto
            {
                Storedpfu =(byte)(x as Enum).GetHashCode(),
                Displayed = (x as Enum).GetDisplayName()
            })
            .ToList();
    }
}
//public class DropdownItemDto
//{
//    public byte Value { get; set; }
//    public string Text { get; set; }
//}
