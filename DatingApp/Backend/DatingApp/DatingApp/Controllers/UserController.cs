using AutoMapper;
using DatingApp.API.Extensions;
using DatingApp.API.Helpers;
using DatingApp.DTOs;
using DatingApp.Extensions;
using DatingApp.Interfaces;
using DatingDatingApp.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        internal readonly IUserRepository m_UserRepository;
        internal readonly IMapper m_Mapper;
        private readonly IPhotoService m_PhotoService;
        public UserController(ILogger<UserController> logger, IUserRepository userRepository,
        IMapper mapper, IPhotoService photoService)
        {
            _logger = logger;
            m_UserRepository = userRepository;
            m_Mapper = mapper;
            m_PhotoService = photoService;
        }

        [HttpGet]
        [Route("api/users")]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetUsers([FromQuery]UserParams userParams)
        {
            var user = await m_UserRepository.GetMemberByNameAsync(User.GetUsername());
            userParams.CurrentUserName = user.UserName;

            if (string.IsNullOrEmpty(userParams.Gender))
            {
                userParams.Gender = user.Gender == "male" ? "female" : "male";
            }
            
            var users = await m_UserRepository.GetAllMembersAsync(userParams);

            Response.AddPaginationHeader(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPage);

            return Ok(users);
        }

        [HttpGet]
        [Route("api/username/{username}", Name = "GetUser")]
        public async Task<ActionResult<MemberDTO>> GetUserByName(string username)
        {
            var user = await m_UserRepository.GetMemberByNameAsync(username);
            return Ok(user);
        }

        [HttpGet]
        [Route("api/id")]
        public async Task<ActionResult<MemberDTO>> GetUserById(int id)
        {
            var user = await m_UserRepository.GetUserByIdAsync(id);
            var userToReturn = m_Mapper.Map<MemberDTO>(user);
            return Ok(userToReturn);
        }

        [HttpGet]
        [Route("api/error")]
        public ActionResult Error()
        {
            return StatusCode(404);
        }

        [HttpPut]
        [Route("api/update")]
        public async Task<ActionResult> UpdateUser(MemberUpdateDTO member)
        {
            var user = await m_UserRepository.GetUserByNameAsync(member.userName);

            m_Mapper.Map(member, user);

            m_UserRepository.Update(user);

            if(await m_UserRepository.SaveAllAsync())
            {
                return NoContent();
            }

            return BadRequest("User update failed");
        }

        [HttpPost]
        [Route("api/addphoto")]
        public async Task<ActionResult<PhotoDTO>> AddPhoto(IFormFile file)
        {
            var user = await m_UserRepository.GetUserByNameAsync(User.GetUsername());
            var result = await m_PhotoService.AddPhotoAsync(file);

            if(result.Error !=null)
            {
                return BadRequest();
            }

            var photo = new Photo()
            {
                Url = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId
            };

            if(user.Photos.Count == 0)
            {
                photo.IsMain = true;
            }

            user.Photos.Add(photo);

            if(await m_UserRepository.SaveAllAsync())
            {
                return CreatedAtRoute("GetUser", new {username = user}, m_Mapper.Map<PhotoDTO>(photo));
            }

            return BadRequest("Problem adding photo");
        }
    
        [HttpPut]
        [Route("api/set-main-photo")]
        public async Task<ActionResult> SetMainPhoto(int photoId)
        {
            var user = await m_UserRepository.GetUserByNameAsync(User.GetUsername());

            var photo = user.Photos.FirstOrDefault(x => x.Id == photoId);

            if(photo.IsMain) return BadRequest("This photo is already main");

            var currentMainPhoto = user.Photos.FirstOrDefault(x => x.IsMain);

            if(currentMainPhoto != null) currentMainPhoto.IsMain = false;

            photo.IsMain = true;

            if(await m_UserRepository.SaveAllAsync())
            {
                return NoContent();
            }

            return BadRequest("Failed to set main photo");
        }
    }
}
