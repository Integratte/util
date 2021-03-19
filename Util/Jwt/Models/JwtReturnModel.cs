using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Integratte.Util.Jwt.Models
{
    public class JwtReturnModel
    {
        public JwtReturnModel()
        {
            Claims = new List<Claim>();

        }

        public string Token { get; set; }

        public DateTime Expiration { get; set; }

        public List<Claim> Claims { get; set; }

    }

}
