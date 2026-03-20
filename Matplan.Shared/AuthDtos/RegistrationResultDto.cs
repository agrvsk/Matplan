using System;
using System.Collections.Generic;
using System.Text;

namespace Matplan.Shared.AuthDtos;

public record RegistrationResultDto(bool Succeeded, IEnumerable<string> Errors);