using Microsoft.AspNetCore.Mvc;
using WebFinalProject.Models;
using WebFinalProject.UseCases;
using WebFinalProject.UseCases.Users.CreateUser;

namespace WebFinalProject.Controller;

[ApiController]
[Route("??")]
public class UserController : ControllerBase
{
    [HttpPost("??")]
    public async Task<CreateUserResponse> CreateUser([FromBody]CreateUserRequest user)
    {
        var request = new CreateUserRequest 
    }
}