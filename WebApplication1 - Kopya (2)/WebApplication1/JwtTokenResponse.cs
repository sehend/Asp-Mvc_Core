using System;

namespace WebApplication1
{
    public class JwtTokenResponse
    {
        public JwtTokenResponse(string token, DateTime expireDate)
        {
            Token = token;
            ExpireDate = expireDate;
        }

        public string Token { get; set; }

        public DateTime ExpireDate { get; set; }

    }
}
