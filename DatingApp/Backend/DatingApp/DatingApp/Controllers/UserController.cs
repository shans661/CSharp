using AutoMapper;
using DatingApp.DTOs;
using DatingApp.Interfaces;
using DatingDatingApp.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        internal readonly IUserRepository m_UserRepository;
        internal readonly IMapper m_Mapper;
        public UserController(ILogger<UserController> logger, IUserRepository userRepository,
        IMapper mapper)
        {
            _logger = logger;
            m_UserRepository = userRepository;
            m_Mapper = mapper;
        }

        [HttpGet]
        [Route("api/users")]
        public async Task<ActionResult<IEnumerable<MemberDTO>>> GetUsers()
        {
            var users = await m_UserRepository.GetAllMembersAsync();
            return Ok(users);
        }

        [HttpGet]
        [Route("api/username/{username}")]
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
    }
}
