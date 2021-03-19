using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Integratte.Util.Jwt.Models
{
    public class JwtResponseModel
    {
        public JwtResponseModel()
        {
            Claims = new List<Claim>();

        }

        public string Token { get; set; }

        public DateTime Expiration { get; set; }

        public List<Claim> Claims { get; set; }

    }

}
