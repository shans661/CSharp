using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Helpers;
using DatingApp.DTOs;
using DatingApp.Helpers;
using DatingDatingApp.API.Entities;

namespace DatingApp.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likeUserId);

        Task<AppUser> GetUsersWithLikes(int userId);

        Task<PagedList<LikeDTO>> GetUserLikes(LikesParams likesParams);
    }
}