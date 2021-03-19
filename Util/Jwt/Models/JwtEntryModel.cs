using System.Collections.Generic;
using System.Security.Claims;

namespace Integratte.Util.Jwt.Models
{
    public class JwtEntryModel
    {
        public string SecretKey { get; set; }
        public int MinutesToExpiration { get; set; }
        public List<Claim> Claims { get; set; }

    }

}
