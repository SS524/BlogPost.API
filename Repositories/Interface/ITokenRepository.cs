using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BlogAPI.Repositories.Interface
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user, List<string> roles);
    }
}
