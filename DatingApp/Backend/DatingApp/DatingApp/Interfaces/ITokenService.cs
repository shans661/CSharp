using DatingDatingApp.API.Entities;

namespace DatingApp.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User appUser);
    }
}