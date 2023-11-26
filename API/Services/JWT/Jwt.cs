﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using API.Data.Models;
using Microsoft.IdentityModel.Tokens;

namespace API.Services.JWT;

class Jwt : IJWT
{
    private const string jwtseckey = "V4XnjsgnRQuUecN27lwoCB82i4AbDMoX1GIFLbtolN4P8P18IRXFVLojx4vwLi7";

    private IConfiguration _config;

    public Jwt(IConfiguration config)
    {
        _config = config;
    }

    public string CreateToken(User user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.username)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtseckey));

        var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

        var token = new JwtSecurityToken(
            issuer: "",
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: cred
        );
        var jwt = new JwtSecurityTokenHandler().WriteToken(token);
        return jwt;
    }
    
}