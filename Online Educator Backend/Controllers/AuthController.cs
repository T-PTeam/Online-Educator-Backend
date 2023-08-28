using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Online_Educator_Backend.Model;
using Online_Educator_Backend.Data.Repositorys;

public class AuthController : Controller
{

    readonly IUserRepository _authorRepository;
    public AuthController(IUserRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    [HttpPost("/login")]
    public IActionResult Login([FromBody] User loginData)
    {
        
        User? user = _authorRepository.GetUsers().FirstOrDefault(p => p.Email == loginData.Email && p.Password == loginData.Password);

        
        if (user is null)
            return Unauthorized();

        var claims = new List<Claim> { new Claim(ClaimTypes.Name, user.Email) };

        
        var jwt = new JwtSecurityToken(
            issuer: AuthOptions.ISSUER,
            audience: AuthOptions.AUDIENCE,
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(2)),
            signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

        var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

        // формуємо відповідь
        var response = new
        {
            access_token = encodedJwt,
            username = user.Email
        };

        return Json(response);
    }
}

