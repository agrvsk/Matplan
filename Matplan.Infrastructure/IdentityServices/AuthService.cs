using AutoMapper;
using Matplan.EntityModels.Models;
using Matplan.EntityModels.Exceptions;
using Matplan.Shared.AuthDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Matplan.Infrastructure.IdentityModel;
using Matplan.Shared.Configurations;
using Matplan.Services.Contracts;

namespace Matplan.Infrastructure.IdentityServices;
public class AuthService : IAuthService
{
    private readonly IMapper mapper;
    private readonly UserManager<User_USR> userManager;
    private readonly RoleManager<IdentityRole> roleManager;
    private readonly JwtSettings jwtSettings;
    private User_USR? user;

    public AuthService(
        IMapper mapper,
        UserManager<User_USR> userManager,
        RoleManager<IdentityRole> roleManager,
        IOptions<JwtSettings> jwtSettings
        )
    {
        this.mapper = mapper;
        this.userManager = userManager;
        this.roleManager = roleManager;
        this.jwtSettings = jwtSettings.Value;
    }

    public async Task<TokenDto> CreateTokenAsync(bool addTime)
    {
        JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

        SigningCredentials signing = GetSigningCredentials();
        IEnumerable<Claim> claims = await GetClaimsAsync();
        JwtSecurityToken token = GenerateToken(signing, claims);

        ArgumentNullException.ThrowIfNull(user);
        user.RefreshToken = GenerateRefreshToken();

        if (addTime)
            user.RefreshTokenExpireTime = DateTime.UtcNow.AddDays(3);

        var res = await userManager.UpdateAsync(user);
        if (!res.Succeeded) throw new Exception(string.Join("/n", res.Errors));

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);
        return new TokenDto(jwt, user.RefreshToken!);
    }

    private string? GenerateRefreshToken()
    {
        var randomNumber = new byte[32];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }

    private JwtSecurityToken GenerateToken(SigningCredentials signing, IEnumerable<Claim> claims)
    {
        var token = new JwtSecurityToken(
                                    issuer: jwtSettings.Issuer,
                                    audience: jwtSettings.Audience,
                                    claims: claims,
                                    expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.Expires)),
                                    signingCredentials: signing);

        return token;
    }

    private async Task<IEnumerable<Claim>> GetClaimsAsync()
    {
        ArgumentNullException.ThrowIfNull(user);
        
        var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.Name, user.UserName!),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            //Add more if needed
        };

        //if (user.CourseId != null && user.CourseId.HasValue)
        //{
        //    claims.Add(new Claim("CourseId", user.CourseId?.ToString()));

        //}

        var roles = await userManager.GetRolesAsync(user);

        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }

        return claims;

    }
    public async Task<IEnumerable<string>> GetAllRolesAsync()
    {
        var roles = roleManager.Roles.Select(r => r.Name).ToList();
        return await Task.FromResult(roles.Where(r => r != null).Cast<string>());
    }

    private SigningCredentials GetSigningCredentials()
    {
        var key = Encoding.UTF8.GetBytes(jwtSettings.SecretKey);
        var secret = new SymmetricSecurityKey(key);

        return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
    }
    public async Task<RegistrationResultDto> RegisterRoleAsync(RoleRegistrationDto roleRegistrationDto)
    {
        ArgumentNullException.ThrowIfNull(roleRegistrationDto);
        var isRoleValid = !string.IsNullOrWhiteSpace(roleRegistrationDto.RoleName);
        if (!isRoleValid)
            return new RegistrationResultDto(false, new[] { "Role does not exist" });
          //return IdentityResult.Failed(new IdentityError { Description = "Role may not be blank" });

        IdentityRole r = new(roleRegistrationDto.RoleName);
        var result = await roleManager.CreateAsync(r);
        var myresult = mapper.Map<RegistrationResultDto>(result);
        return myresult;
    }

    public async Task<RegistrationResultDto> RegisterUserAsync(UserRegistrationDto userRegistrationDto)
    {
        ArgumentNullException.ThrowIfNull(userRegistrationDto);

        var isRoleValid = !string.IsNullOrWhiteSpace(userRegistrationDto.Role);

        if (isRoleValid)
        {
            var roleExists = await roleManager.RoleExistsAsync(userRegistrationDto.Role!);
            if (!roleExists)
                return new RegistrationResultDto(false, new[] { "Role does not exist" });
            //return IdentityResult.Failed(new IdentityError { Description = "Role does not exist" });
        }

        var user = mapper.Map<User_USR>(userRegistrationDto);
        var result = await userManager.CreateAsync(user, userRegistrationDto.Password);

        if (!result.Succeeded) 
        {
            var myresult2 = mapper.Map<RegistrationResultDto>(result);
            return myresult2;
        }


        if (isRoleValid)
            result = await userManager.AddToRoleAsync(user, userRegistrationDto.Role!);

        var myresult = mapper.Map<RegistrationResultDto>(result);
        return myresult;
//        return result;
    }

    public async Task<bool> ValidateUserAsync(UserAuthDto userDto)
    {
        ArgumentNullException.ThrowIfNull(userDto);

        user = await userManager.FindByNameAsync(userDto.USR_Login);

        return user != null && await userManager.CheckPasswordAsync(user, userDto.USR_Passord);
    }

    public async Task<TokenDto> RefreshTokenAsync(TokenDto token)
    {
        ClaimsPrincipal principal = GetPrincipalFromExpiredToken(token.AccessToken);
        User_USR? user = await userManager.FindByNameAsync(principal.Identity?.Name!);

        if (user == null)
            throw new TokenValidationException("User not found");

        if (user!.RefreshToken != token.RefreshToken)
            throw new TokenValidationException("Refreshtoken do not match");

        if (user.RefreshTokenExpireTime <= DateTime.Now)
            throw new TokenValidationException("Refreshtoken has expired");

        this.user = user;

        return await CreateTokenAsync(addTime: false);

    }

    private ClaimsPrincipal GetPrincipalFromExpiredToken(string accessToken)
    {
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = false,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings.Issuer,
            ValidAudience = jwtSettings.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey))
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        ClaimsPrincipal principal = tokenHandler.ValidateToken(accessToken, tokenValidationParameters, out SecurityToken securityToken);

        if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
        {
            throw new SecurityTokenException("Invalid token");
        }

        return principal;
    }
}
