using System.ComponentModel.DataAnnotations;

namespace Matplan.Shared.AuthDtos;
public record UserAuthDto
{
    [Required]
    public string USR_Login { get; init; } = string.Empty;

    [Required]
    public string USR_Passord { get; init; } = string.Empty;
}
