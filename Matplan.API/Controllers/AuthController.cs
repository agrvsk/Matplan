using Matplan.Shared.AuthDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Matplan.Services.Contracts;

namespace Matplan.API.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IServiceManager serviceManager;

    public AuthController(IServiceManager serviceManager)
    {
        this.serviceManager = serviceManager;
    }
    [HttpPost("role")]
    [SwaggerOperation(
    Summary = "Register a new role",
    Description = "Creates a new role with the provided name.")]
    [SwaggerResponse(StatusCodes.Status201Created, "Role successfully registered")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input or registration failed")]
    public async Task<IActionResult> RegisterRole(RoleRegistrationDto roleRegistrationDto)
    {

        RegistrationResultDto result = await serviceManager.AuthService.RegisterRoleAsync(roleRegistrationDto);
        return result.Succeeded ? StatusCode(StatusCodes.Status201Created) : BadRequest(result.Errors);
    }

    [HttpGet("roles")]
    [SwaggerOperation(
    Summary = "Get all roles",
    Description = "Returns a list of all available roles in the system.")]
    [SwaggerResponse(StatusCodes.Status200OK, "Roles retrieved successfully", typeof(IEnumerable<string>))]
    public async Task<ActionResult<IEnumerable<string>>> GetRoles()
    {
        var roles = await serviceManager.AuthService.GetAllRolesAsync();
        return Ok(roles);
    }

    [HttpPost]
    [SwaggerOperation(
        Summary = "Register a new user",
        Description = "Creates a new user account with the provided registration details."
    )]
    [SwaggerResponse(StatusCodes.Status201Created, "User successfully registered")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Invalid input or registration failed")]
    public async Task<IActionResult> RegisterUser(UserRegistrationDto userRegistrationDto)
    {

        RegistrationResultDto result = await serviceManager.AuthService.RegisterUserAsync(userRegistrationDto);
        return result.Succeeded ? StatusCode(StatusCodes.Status201Created) : BadRequest(result.Errors);
    }

    [HttpPost("login")]
    [AllowAnonymous]
    [SwaggerOperation(
        Summary = "Authenticate user",
        Description = "Validates user credentials and returns a JWT token for authorization."
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "Authentication successful", typeof(TokenDto))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Invalid username or password")]
    public async Task<IActionResult> Authenticate(UserAuthDto user)
    {
        if (!await serviceManager.AuthService.ValidateUserAsync(user))
            return Unauthorized();

        var tokenDto = await serviceManager.AuthService.CreateTokenAsync(addTime: true);
        return Ok(tokenDto);
    }
}
