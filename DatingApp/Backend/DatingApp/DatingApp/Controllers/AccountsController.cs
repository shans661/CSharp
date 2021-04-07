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
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly DataBaseContext m_Context;
        private readonly ITokenService m_TokenService;
        public AccountsController(DataBaseContext context, ITokenService tokenService)
        {
            m_Context = context;
            m_TokenService = tokenService;
        }

        [HttpPost]
        [Route("api/register")]
        public async Task<ActionResult> Register(RegisterDTO appUser)
        {
            //Check the user exists
            if (await IsUserExists(appUser.Username)) return BadRequest("User name exists");

            var user = new AppUser();
            HMACSHA512 encryptor = new HMACSHA512();

            user.UserName = appUser.Username;
            user.PasswordHash = encryptor.ComputeHash(Encoding.UTF32.GetBytes(appUser.Password));
            user.PasswordSalt = encryptor.Key;

            await m_Context.User.AddAsync(user);
            var result = await m_Context.SaveChangesAsync();

            if (result == 1)
            {
                return StatusCode(201);
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
            var user = await m_Context.User.FirstOrDefaultAsync(x => x.UserName == appUser.UserName);

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
                PhotoUrl = user.Photos?.FirstOrDefault(x => x.IsMain)?.Url
            };
        }

        private async Task<bool> IsUserExists(string username)
        {
            return await m_Context.User.AnyAsync(x => x.UserName == username);
        }
    }
}
