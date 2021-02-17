using DatingDatingApp.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [ApiController]
    public class AccountsController : ControllerBase
    {
        internal readonly DataBaseContext m_Context;
        public AccountsController(DataBaseContext context)
        {
            m_Context = context;
        }

        [HttpGet]
        [Route("api/resister")]
        public async Task<ActionResult> Register(string userName, string password)
        {
            var isUserExists = await m_Context.User.AnyAsync(x => x.UserName == userName);

            if (isUserExists)
            {
                return BadRequest();
            }
            else
            {
                var user = new User();
                HMACSHA512 encryptor = new HMACSHA512();

                user.UserName = userName;
                user.PasswordHash = encryptor.ComputeHash(Encoding.UTF8.GetBytes(password));
                user.PasswordSalt = encryptor.Key;

                await m_Context.User.AddAsync(user);
                var result = await m_Context.SaveChangesAsync();

                if (result == 1)
                {
                    return Accepted();
                }
                else
                {
                    return BadRequest();
                }
            }
        }
    }
}
