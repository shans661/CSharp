using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API;
using DatingApp.API.Helpers;
using DatingApp.DTOs;
using DatingApp.Extensions;
using DatingApp.Helpers;
using DatingApp.Interfaces;
using DatingDatingApp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Services
{
    public class LikesRepository : ILikesRepository
    {
        private readonly DataBaseContext m_Context;

        public LikesRepository(DataBaseContext context)
        {
            m_Context = context;
        }

        public async Task<UserLike> GetUserLike(int sourceUserId, int likeUserId)
        {
            return await m_Context.Likes.FindAsync(sourceUserId, likeUserId);
        }

        public async Task<PagedList<LikeDTO>> GetUserLikes(LikesParams likesParams)
        {
            var users = m_Context.User.OrderBy(x => x.UserName).AsQueryable();
            var likes = m_Context.Likes.AsQueryable();

            if(likesParams.Predicate == "liked")
            {
                likes = likes.Where(x => x.SourceUserId == likesParams.UserId);
                users = likes.Select(x => x.LikedUser);
            }

            if(likesParams.Predicate == "likedBy")
            {
                likes = likes.Where(x => x.LikedUserId == likesParams.UserId);
                users = likes.Select(x => x.SourceUser);
            }

            var likeUsers = users.Select(x => new LikeDTO
            {
                UserName = x.UserName,
                KnownAs = x.KnownAs,
                Age = x.DateOfBirth.CalculateAge(),
                PhotoUrl = x.Photos.FirstOrDefault(p => p.IsMain).Url,
                City = x.City,
                Id = x.Id
            });

            return await PagedList<LikeDTO>.CreateAsync(likeUsers, likesParams.PageNumber, likesParams.PageSize);
        }

        public async Task<AppUser> GetUsersWithLikes(int userId)
        {
            return await m_Context.User.Include(x => x.LikedUsers).FirstOrDefaultAsync(x => x.Id == userId);
        }
    }
}