using System;
using System.Collections.Generic;
using System.Text;

namespace Matplan.Shared.KodtabellDtos;

public record KodtabellByteDto
{
    public byte Storedpfu { get; init; }
    public string? Displayed { get; init; } 
}
