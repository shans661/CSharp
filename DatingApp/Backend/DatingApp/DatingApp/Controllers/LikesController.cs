using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.DTOs;
using DatingApp.Extensions;
using DatingApp.Helpers;
using DatingApp.Interfaces;
using DatingDatingApp.API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    [Authorize]
    [ApiController]
    public class LikesController : ControllerBase
    {
        private readonly IUserRepository m_UserRepository;
        private readonly ILikesRepository m_LikesRepository;

        public LikesController(IUserRepository userRepository, ILikesRepository likesRepository)
        {
            m_UserRepository = userRepository;
            m_LikesRepository = likesRepository;
        }       

        [HttpPost]
        [Route("api/like/{username}")]
        public async Task<ActionResult> AddLike(string username)
        {
            var sourceUserId = User.GetUserId();
            var likeUser = await m_UserRepository.GetUserByNameAsync(username);
            var sourceUser = await m_LikesRepository.GetUsersWithLikes(sourceUserId);

            if(likeUser == null) return NotFound("Liked user not exists");

            var userLike = await m_LikesRepository.GetUserLike(sourceUserId, likeUser.Id);

            if(userLike != null) return BadRequest("User is already liked");

            userLike = new UserLike()
            {
              LikedUserId = likeUser.Id,
              SourceUserId = sourceUserId  
            };

            sourceUser.LikedUsers.Add(userLike);

            if(await m_UserRepository.SaveAllAsync()) return Ok();
            return BadRequest("Failed to like user");
        }

        [HttpGet]
        [Route("api/like")]
        public async Task<ActionResult<IEnumerable<LikeDTO>>> GetUserLikes([FromQuery]LikesParams likesParams)
        {
            likesParams.UserId = User.GetUserId();
            var users = await m_LikesRepository.GetUserLikes(likesParams);

            return Ok(users);
        }
    }
}