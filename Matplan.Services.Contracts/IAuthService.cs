using Matplan.Shared.AuthDtos;

namespace Matplan.Services.Contracts;
public interface IAuthService
{
    Task<TokenDto> CreateTokenAsync(bool addTime);
    Task<TokenDto> RefreshTokenAsync(TokenDto token);
    Task<RegistrationResultDto> RegisterRoleAsync(RoleRegistrationDto roleRegistrationDto);
    Task<IEnumerable<string>> GetAllRolesAsync();
    Task<RegistrationResultDto> RegisterUserAsync(UserRegistrationDto userRegistrationDto);
    Task<bool> ValidateUserAsync(UserAuthDto user);
}
