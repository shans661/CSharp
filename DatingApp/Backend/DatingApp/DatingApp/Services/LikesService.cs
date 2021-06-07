using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API;
using DatingApp.DTOs;
using DatingApp.Interfaces;
using DatingDatingApp.API.Entities;

namespace DatingApp.Services
{
    public class LikesService : ILikesRepository
    {
        private readonly DataBaseContext m_Context;

        public LikesService(DataBaseContext context)
        {
            m_Context = context;
        }

        public Task<UserLike> GetUserLike(int sourceUserId, int likeUserId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<LikeDTO>> GetUserLikes(string predicate, int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<AppUser> GetUsersWithLikes(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}