using Integratte.Util.Jwt.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Integratte.Util.Jwt
{
    public class JwtGenerator
    {
        public static JwtResponseModel RetornoJwt(JwtEntryModel jwtEntryModel)
        {
            DateTime expiracao = DateTime.UtcNow.AddMinutes(jwtEntryModel.MinutesToExpiration);

            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(jwtEntryModel.SecretKey);
            
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(jwtEntryModel.Claims),
                Expires = expiracao,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };
            
            string token = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));

            return new JwtResponseModel()
            {
                Claims = jwtEntryModel.Claims,
                Expiration = expiracao.ToUniversalTime(),
                Token = token,

            };

        }

    }

}
