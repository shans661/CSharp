using AutoMapper;
using DatingApp.API.Helpers;
using DatingApp.DTOs;
using DatingApp.Interfaces;
using DatingDatingApp.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly DataBaseContext m_Context;
        private readonly ITokenService m_TokenService;
        private readonly IMapper m_Mapper;
        
        public AccountsController(DataBaseContext context, ITokenService tokenService, IMapper mapper)
        {
            m_Context = context;
            m_TokenService = tokenService;
            m_Mapper = mapper;
        }

        [HttpPost]
        [Route("api/register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO appUser)
        {
            //Check the user exists
            if (await IsUserExists(appUser.Username)) return BadRequest("User name exists");

            var user = m_Mapper.Map<AppUser>(appUser);
            HMACSHA512 encryptor = new HMACSHA512();

            user.UserName = appUser.Username;
            user.PasswordHash = encryptor.ComputeHash(Encoding.UTF32.GetBytes(appUser.Password));
            user.PasswordSalt = encryptor.Key;

            await m_Context.User.AddAsync(user);
            var result = await m_Context.SaveChangesAsync();

            if (result == 1)
            {
                return new UserDTO()
                {
                    Username = user.UserName,
                    Gender = user.Gender,
                    KnownAs = user.KnownAs,
                    PhotoUrl = user.Photos?.FirstOrDefault(x => x.IsMain).Url,
                    Token = m_TokenService.CreateToken(user)
                };
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("api/login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO appUser)
        {
            var user = await m_Context.User.Include(x => x.Photos).FirstOrDefaultAsync(x => x.UserName == appUser.UserName);

            if(user == null) return Unauthorized("User name not exists");

            var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF32.GetBytes(appUser.Password));

            for(int index =0; index < computedHash.Length; index ++)
            {
                if(user.PasswordHash[index] != computedHash[index])
                {
                    return Unauthorized("Incorrect password");
                }
            }

            return new UserDTO()
            {
                Username = appUser.UserName,
                Token = m_TokenService.CreateToken(user),
                PhotoUrl = user.Photos?.FirstOrDefault(x => x.IsMain)?.Url,
                KnownAs = user.KnownAs,
                Gender = user.Gender
            };
        }

        private async Task<bool> IsUserExists(string username)
        {
            return await m_Context.User.AnyAsync(x => x.UserName == username);
        }
    }
}
