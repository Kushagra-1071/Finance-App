using Backend.Models;

namespace Backend.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
