using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Services;

namespace Test.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet(Name = "Search")]
    public async Task<SearchFilterResponse> Get([FromQuery] SearchFilterRequest filter, [FromServices] IUserService userService, CancellationToken cancellationToken) 
        => await userService.SearchAsync(filter, cancellationToken);
}
