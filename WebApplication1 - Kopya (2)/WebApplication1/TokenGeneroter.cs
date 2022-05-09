using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication1.Model;

namespace WebApplication1
{
    public class TokenGeneroter
    {

        public string GenerateToken(string _role)
        {
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("sehend1907sdfafsd"));

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Role, _role));



            JwtSecurityToken token = new JwtSecurityToken(issuer: "https://localhost",audience: "https://localhost",claims: claims, notBefore:DateTime.Now,expires:DateTime.Now.AddMinutes(2),signingCredentials: credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

           return handler.WriteToken(token);
        }


    }
}
