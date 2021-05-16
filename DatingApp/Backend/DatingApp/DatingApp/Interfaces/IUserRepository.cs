using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Helpers;
using DatingApp.DTOs;
using DatingDatingApp.API.Entities;

namespace DatingApp.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetAllUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByNameAsync(string username);

        Task<PagedList<MemberDTO>> GetAllMembersAsync(UserParams userParams);
        Task<MemberDTO> GetMemberByNameAsync(string username);
    }
}