using API.Data.DTOs;
using API.Data.Models;
using API.Services.Authentication;
using API.Services.JWT;
using API.Services.NewsRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("Authentication")]
public class AuthenticationController : Controller
{
    private readonly IAuthentication _auth;
    private readonly IJWT _jwt;

    public AuthenticationController(IAuthentication auth, IJWT jwt)
    {
        _auth = auth;
        _jwt = jwt;
    }
    
    
    [HttpPost("Login")]
    public async Task<bool> Login(UserDTO loginrequest)
    {
        return await _auth.Login(loginrequest);
    }
    
    [HttpPost("LoginTest")]
    public async Task<string> LoginTest(UserDTO loginrequest)
    {
        return await _auth.LoginTest(loginrequest);
    }
    
    [HttpPut("Register")]
    public async Task<bool> Register(UserDTO registerrequest)
    {
        return await _auth.Register(registerrequest);
    }
    
    [HttpPut("GetUserInfo")]
    public async Task<User> GetUserInfo(AuthRequestDTO inforequest)
    {
        return await _auth.GetUserInfo(inforequest);
    }

    [HttpPut("CheckToken")]
    public async Task<bool> CheckToken(string token)
    {
        var check = _jwt.VerifyToken(token);
            if (check)
            {
                return true;
            }
            else
            {
                return false;
            }
    }
    
}