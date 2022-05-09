using JWT.Core.Application.Dto;
using JWT.Core.Domain;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT.infrastructure.Tools
{
    public class JwtTokenGenerator
    {

        public static JwtTokenResponse GenerateToken(ChekUserResponsDto dto)
        {
            var security = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenSettings.Key));   

            SigningCredentials Credentials = new SigningCredentials(security,SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Role, dto.Role));

            claims.Add(new Claim(ClaimTypes.Name,dto.UserName));

            claims.Add(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString()));

            var expiredate = DateTime.UtcNow.AddMinutes(1);

            JwtSecurityToken token = new JwtSecurityToken(issuer: JwtTokenSettings.Issuer,audience: JwtTokenSettings.Audience,claims:claims,notBefore:DateTime.UtcNow,expires:expiredate,signingCredentials: Credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return new JwtTokenResponse (handler.WriteToken(token),expiredate);
        }

    }
}
